using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace El_Mundo_de_5_Peso
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent(); 
            
            Conexion cn = new Conexion();
            cn.Open();

            string query = "SELECT * FROM Usuario";
            SqlCommand comando = new SqlCommand(query, cn.conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable table = new DataTable();
            data.Fill(table);

            DGV_Usuarios.DataSource = table;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void BT_CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_MinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public int xClick = 0, yClick = 0;

        private void BT_AgrUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Usuario agrUser = new Usuario("agregar");
            agrUser.ShowDialog();
            this.Visible = true;
        }

        private void BT_ModUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Usuario modUser = new Usuario("modificar");
            modUser.ShowDialog();
            this.Visible = true;
        }

        private void BT_BorUser_Click(object sender, EventArgs e) // TODO: Verificar que funcione
        {
            int id = 2;
            bool ok = false;
            // TODO: Verificar que haya seleccionado un usuario //

            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    Obtener obtener = new Obtener();
                    List<ObjUsuario> list = obtener.ObtenerLU();

                    foreach(ObjUsuario usuario in list)
                    {
                        if(usuario.id == id)
                        {
                            SqlCommand cmd = new SqlCommand("DELETE Usuario where id = " + usuario.id, conexion);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Se ha eliminado el usuario " + usuario.usuario);

                            QueryUsuario query = new QueryUsuario("eliminar", usuario);
                        }
                    }
                    
                    if(!ok)
                    {
                        MessageBox.Show("No se encontró el usuario");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void Usuarios_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
