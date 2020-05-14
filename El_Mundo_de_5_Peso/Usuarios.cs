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
    public partial class Usuarios : Form
    {
        public Usuarios()
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

        private void BT_AgrUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Usuario agrUser = new Usuario(true);
            agrUser.ShowDialog();
            this.Visible = true;
        }

        private void BT_ModUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Usuario modUser = new Usuario(false);
            modUser.ShowDialog();
            this.Visible = true;
        }

        private void Usuarios_Load(object sender, EventArgs e)
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
