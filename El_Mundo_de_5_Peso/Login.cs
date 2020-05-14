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
    public partial class Login : Form
    {
        public int xClick = 0, yClick = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario, pass FROM Usuario WHERE Usuario='" + TB_User.Text + "' AND pass='" + TB_Password.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            this.Visible = false;
                            AdminUI admForm = new AdminUI(TB_User.Text);
                            admForm.ShowDialog();
                            TB_User.Text = "Usuario";
                            TB_Password.Text = "Contraseña";
                            this.Visible = true;
                        }
                        else
                        {
                            timer1.Enabled = true;
                            timer1.Start();

                            TB_Password.UseSystemPasswordChar = false;
                            TB_User.ForeColor = Color.Red;
                            TB_User.Text = "Datos";
                            TB_Password.ForeColor = Color.Red;
                            TB_Password.Text = "Incorrectos";
                        }
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            TB_Password.UseSystemPasswordChar = false;
            TB_User.ForeColor = Color.Black;
            TB_Password.ForeColor = Color.Black;
            TB_User.Text = "Usuario";
            TB_Password.Text = "Contraseña";
            TB_User.Refresh();
            TB_Password.Refresh();
            timer1.Enabled = false;
        }

        private void BT_Ingresar_Click(object sender, EventArgs e)
        {
            logins();
        }

        private void TB_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                logins();
            }
        }

        private void TB_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                logins();
            }
        }

        private void TB_Password_Click(object sender, EventArgs e)
        {
            if (TB_Password.Text == "Contraseña")
            {
                TB_Password.Text = ""; 
                if (TB_User.Text == "")
                {
                    TB_User.Text = "Usuario";
                }
            }
            else if(TB_Password.Text == "Incorrectos")
            {
                timer1.Stop();
                TB_User.ForeColor = Color.Black;
                TB_Password.ForeColor = Color.Black;
                TB_User.Text = "";
                TB_Password.Text = "";
                if (TB_User.Text == "")
                {
                    TB_User.Text = "Usuario";
                }
            }
            else if(TB_User.Text == "")
            {
                TB_User.Text = "Usuario";
            }
            TB_Password.UseSystemPasswordChar = true;
        }

        private void TB_User_Click(object sender, EventArgs e)
        {
            if (TB_User.Text == "Usuario")
            {
                TB_User.Text = "";
                if(TB_Password.Text == "")
                {
                    TB_Password.UseSystemPasswordChar = false;
                    TB_Password.Text = "Contraseña";
                }
            }
            else if (TB_User.Text == "Datos")
            {
                timer1.Stop();
                TB_User.ForeColor = Color.Black;
                TB_Password.ForeColor = Color.Black;
                TB_User.Text = "";
                TB_Password.Text = "";
                if (TB_Password.Text == "")
                {
                    TB_Password.UseSystemPasswordChar = false;
                    TB_Password.Text = "Contraseña";
                }
            }
            else if (TB_Password.Text == "")
            {
                TB_Password.UseSystemPasswordChar = false;
                TB_Password.Text = "Contraseña";
            }
        }

        private void BT_MinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BT_CloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
