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
    public partial class AdminUI : Form
    {
        public AdminUI(string nameUser)
        {
            InitializeComponent();
            LB_NameUser.Text = nameUser;
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {

        }

        private void BT_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_MinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BT_CloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_Ventas_Click(object sender, EventArgs e) // TODO: Enviar datos de usuario actual
        {
            this.Visible = false;
            Ventas ventas = new Ventas();
            ventas.ShowDialog();
            this.Visible = true;
        }

        private void BT_Inventario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Inventario inventario = new Inventario();
            inventario.ShowDialog();
            this.Visible = true;
        }

        private void BT_AdmUsers_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
            this.Visible = true;
        }

        private void BT_Opciones_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ModificarUsuario modUser = new ModificarUsuario(); // TODO: Enviar datos de usuario actual
            modUser.ShowDialog();
            this.Visible = true;
        }

        public int xClick = 0, yClick = 0;

        private void AdminUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
