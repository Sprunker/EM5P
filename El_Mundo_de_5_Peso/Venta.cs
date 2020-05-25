using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Mundo_de_5_Peso
{
    public partial class Venta : Form
    {
        string mod;
        bool E = true;
        int idVenta;
        Obtener obtener = new Obtener();
        List<ObjArticulo> list;

        public Venta(string mod, int idVenta)
        {
            InitializeComponent();

            list = obtener.ObtenerLA();
            this.mod = mod;

            if (mod == "agregar")
            {
                // Agregar propiedades //
                LB_Titulo.Location = new Point(76, 28);
                LB_Titulo.Text = "NUEVO USUARIO";
                BT_Agregar.Text = "Agregar Usuario";

                BT_Agregar.Click += new System.EventHandler(BT_AgrVenta_Click);
            }
            else if (mod == "modificar")
            {
                // Agregar propiedades //
                LB_Titulo.Location = new Point(40, 34);
                LB_Titulo.Text = "MODIFICAR USUARIO";
                BT_Agregar.Text = "Guardar Datos";

                BT_Agregar.Click += new System.EventHandler(BT_ModVenta_Click);

                this.idVenta = idVenta;

                if (idVenta != 0)
                {
                    Obtener obtener = new Obtener();
                    List<ObjVenta> list = obtener.ObtenerLV();
                    ObjVenta venta = new ObjVenta();

                    try
                    {
                        for (int i = 1; i < list.Count; i++)
                        {
                            if (list[i].numVenta == idVenta)
                                venta = new ObjVenta(list[i]);
                        }

                        // Agregar los daos de la venta
                    }
                    catch
                    {
                        MessageBox.Show("No se encontró la venta");

                        E = false;
                    }
                }
            }
        }

        private void BT_AgrVenta_Click(object sender, EventArgs e)
        {
            Verificacion(mod);
        }

        private void BT_ModVenta_Click(object sender, EventArgs e)
        {
            Verificacion(mod);
        }

        public void Verificacion(string instruccion)
        {
            

            ObjUsuario usuario = new ObjUsuario(TB_Nombre.Text, TB_User.Text, TB_Pass.Text, TB_Telefono.Text, DL, H); // Creación del usuario //

            QueryUsuario agregar = new QueryUsuario(instruccion, usuario); // Query para agregar nuevo usuario //
                
            this.Close();
        }

        private void Venta_Load(object sender, EventArgs e)
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

        private void BT_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void Venta_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
