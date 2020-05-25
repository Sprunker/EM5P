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

            DGV_Usuarios.AllowUserToAddRows = false;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'm5PDBDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.m5PDBDataSet.Usuario);

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
            Usuario agrUser = new Usuario("agregar", 0);
            agrUser.ShowDialog();
            this.Visible = true; 
            DGV_Usuarios.Refresh();
        }

        private void BT_ModUser_Click(object sender, EventArgs e)
        {
            if (TB_CodigoUser.Text != "Código" || TB_Nombre.Text != "Nombre" || TB_Usuario.Text != "Usuario")
            {
                int id = 0;

                try
                {
                    id = Convert.ToInt32(TB_CodigoUser.Text);

                    Obtener obtener = new Obtener();
                    List<ObjUsuario> list = obtener.ObtenerLU();

                    foreach(ObjUsuario usuario in list)
                    {
                        if(id == usuario.id)
                        {
                            this.Visible = false;
                            Usuario modUser = new Usuario("modificar", id);
                            modUser.ShowDialog();
                            this.Visible = true;
                            DGV_Usuarios.Refresh();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese un caracter válido");
                }
            }
        }

        private void BT_BorUser_Click(object sender, EventArgs e) // TODO: Verificar que funcione
        {
            if (TB_CodigoUser.Text != "Código" || TB_Nombre.Text != "Nombre" || TB_Usuario.Text != "Usuario")
            {
                int id = 0;

                try
                {
                    id = Convert.ToInt32(TB_CodigoUser.Text);
                }
                catch
                {
                    MessageBox.Show("Ingrese un caracter válido");
                }
                bool ok = false;
                // TODO: Verificar que haya seleccionado un usuario //

                try
                {
                    string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                    using (SqlConnection conexion = new SqlConnection(cnn))
                    {
                        conexion.Open();

                        Obtener obtener = new Obtener();
                        List<ObjUsuario> list = obtener.ObtenerLU();

                        foreach (ObjUsuario usuario in list)
                        {
                            if (usuario.id == id)
                            {
                                SqlCommand cmd = new SqlCommand("DELETE Usuario where id = " + usuario.id, conexion);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Se ha eliminado el usuario " + usuario.usuario);

                                QueryUsuario query = new QueryUsuario("eliminar", usuario);

                                DGV_Usuarios.Refresh();
                            }
                        }

                        if (!ok)
                        {
                            MessageBox.Show("No se encontró el usuario");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                } 
            }
            else
            {
                MessageBox.Show("Ingrese datos para la eliminación");
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
