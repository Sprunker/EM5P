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
            AgregarArticulo agrArt = new AgregarArticulo();
            agrArt.ShowDialog();
            this.Visible = true;
        }

        private void BT_ModArt_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ModificarArticulo modArt = new ModificarArticulo();
            modArt.ShowDialog();
            this.Visible = true;
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
