using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto
{
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
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

        private void PB_Imagen_Click(object sender, EventArgs e)
        {
            try
            {
                OFD_ArtNuevo.Title = "Elige una imagen";
                OFD_ArtNuevo.InitialDirectory = "c:\\";
                OFD_ArtNuevo.Filter = "Archivos jpg (*.jpg)|*.jpg| Archivos png (*.png)|*.png";
                OFD_ArtNuevo.FilterIndex = 1;
                OFD_ArtNuevo.RestoreDirectory = true;
                OFD_ArtNuevo.ShowDialog();

                if (File.Exists(OFD_ArtNuevo.FileName))
                {
                    LB_Imagen.Visible = false;
                    PB_Imagen.ImageLocation = OFD_ArtNuevo.FileName;
                    // Activar boton de quitar imagen
                }
                else
                {
                    MessageBox.Show("No se seleccionó ninguna imagen", "Sin selección",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir");
            }
        }

        private void AgregarArticulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
