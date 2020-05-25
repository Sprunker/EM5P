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
    public partial class Ventas : Form
    {
        int idVenta;

        public Ventas()
        {
            InitializeComponent();

            DGV_Ventas.AllowUserToAddRows = false;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'm5PDBDataSet2.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.m5PDBDataSet2.Venta);

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

        private void BT_ModVenta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Venta venta = new Venta("modificar", idVenta); // TODO: Pasar los datos de la venta que se desea modificar
            venta.ShowDialog();
            this.Visible = true;
        }

        private void BT_NuevaVenta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Venta venta = new Venta("agregar", 0);
            venta.ShowDialog();
            this.Visible = true;
        }

        private void Ventas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
