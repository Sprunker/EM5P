using Producto;
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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();

            DGV_Inventario.AllowUserToAddRows = false;
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

        private void BT_AgregarNuevo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AgregarArticulo agrArt = new AgregarArticulo("agregar", 0);
            agrArt.ShowDialog();
            this.Visible = true;
        }

        private void BT_ModArt_Click(object sender, EventArgs e)
        {
            if (TB_CodArtAgr.Text != "Código de Artículo" || TB_NomArtAgr.Text != "Nombre de Artículo")
            {
                int id = 0;

                try
                {
                    id = Convert.ToInt32(TB_CodArtAgr.Text);

                    Obtener obtener = new Obtener();
                    List<ObjUsuario> list = obtener.ObtenerLU();

                    foreach (ObjUsuario usuario in list)
                    {
                        if (id == usuario.id)
                        {
                            this.Visible = false;
                            AgregarArticulo modArt = new AgregarArticulo("modificar", id);
                            modArt.ShowDialog();
                            this.Visible = true;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese un caracter válido");
                }
            }
            
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'm5PDBDataSet1.Articulo' Puede moverla o quitarla según sea necesario.
            this.articuloTableAdapter.Fill(this.m5PDBDataSet1.Articulo);
        }

        private void Inventario_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
