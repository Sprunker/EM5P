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
    public partial class Usuario : Form
    {
        string mod;

        public Usuario(string mod)
        {
            InitializeComponent();
            this.mod = mod; 
            
            if (mod == "agregar")
            {
                // Agregar propiedades //
                LB_Titulo.Location = new Point(76, 28);
                LB_Titulo.Text = "NUEVO USUARIO";
                BT_AgrUser.Text = "Agregar Usuario";

                BT_AgrUser.Click += new System.EventHandler(BT_AgrUser_Click);
            }
            else if(mod == "modificar")
            {
                // Agregar propiedades //
                LB_Titulo.Location = new Point(40, 34);
                LB_Titulo.Text = "MODIFICAR USUARIO";
                BT_AgrUser.Text = "Guardar Datos";

                BT_AgrUser.Click += new System.EventHandler(BT_ModUser_Click);
            }
        }

        private void BT_AgrUser_Click(object sender, EventArgs e)
        {
            Verificacion("agregar");
        }

        private void BT_ModUser_Click(object sender, EventArgs e)
        {
            Verificacion("modificar");
        }

        public void Verificacion(string instruccion)
        {
            bool DC = true;
            bool DL = true;
            bool H = true;
            // *Hola* //
            // Verificaciones de campos llenos //
            if (TB_Nombre.Text == "Nombre" || TB_Nombre.Text == "" || TB_User.Text == "Usuario" || TB_User.Text == "" || TB_Pass.Text == "Contraseña" ||
                TB_Pass.Text == "" || TB_RepPass.Text == "Repetir Contraseña" || TB_RepPass.Text == "" || TB_Telefono.Text == "Teléfono" || TB_Telefono.Text == "" ||
                TB_DiasLab.Text == "Días Laborales" || TB_Horario.Text == "Horario" || TB_Nombre.Text == "*Campo Obligatorio*" || TB_User.Text == "*Campo Obligatorio*" ||
                TB_Pass.Text == "*Campo Obligatorio*" || TB_RepPass.Text == "*Campo Obligatorio*" || TB_Telefono.Text == "*Campo Obligatorio*" ||
                TB_DiasLab.Text == "*Campo Obligatorio*" || TB_Horario.Text == "*Campo Obligatorio*")
            {
                if (TB_Nombre.Text == "Nombre" || TB_Nombre.Text == "" || TB_Nombre.Text == "*Campo Obligatorio*")
                {
                    TB_Nombre.ForeColor = Color.Red;
                    TB_Nombre.Text = "*Campo Obligatorio*";
                }
                if (TB_User.Text == "Usuario" || TB_User.Text == "" || TB_User.Text == "*Campo Obligatorio*")
                {
                    TB_User.ForeColor = Color.Red;
                    TB_User.Text = "*Campo Obligatorio*";
                }
                if (TB_Pass.Text == "Contraseña" || TB_Pass.Text == "" || TB_Pass.Text == "*Campo Obligatorio*")
                {
                    TB_Pass.ForeColor = Color.Red;
                    TB_Pass.Text = "*Campo Obligatorio*";
                }
                if (TB_RepPass.Text == "Repetir Contraseña" || TB_RepPass.Text == "" || TB_RepPass.Text == "*Campo Obligatorio*")
                {
                    TB_RepPass.ForeColor = Color.Red;
                    TB_RepPass.Text = "*Campo Obligatorio*";
                }
                if (TB_Telefono.Text == "Teléfono" || TB_Telefono.Text == "" || TB_Telefono.Text == "*Campo Obligatorio*")
                {
                    TB_Telefono.ForeColor = Color.Red;
                    TB_Telefono.Text = "*Campo Obligatorio*";
                }
                if (TB_DiasLab.Text == "Días Laborales" || TB_DiasLab.Text == "*Campo Obligatorio*")
                {
                    TB_DiasLab.ForeColor = Color.Red;
                    TB_DiasLab.Text = "*Campo Obligatorio*";
                }
                if (TB_Horario.Text == "Horario" || TB_Horario.Text == "*Campo Obligatorio*")
                {
                    TB_Horario.ForeColor = Color.Red;
                    TB_Horario.Text = "*Campo Obligatorio*";
                }

                MessageBox.Show("Datos Incompletos");

                DC = false;
            }
            
            if (DC)
            {

                if (TB_DiasLab.Text == "Fines de Semana")
                {
                    DL = false;
                }
                if (TB_Horario.Text == "Vespertino")
                {
                    H = false;
                }
            }

            // Fin de verificaciones de campos llenos //

            // Verificacion de formatos de datos //

            // Fin de verificaciones de formatos de datos //

            if (TB_Pass.Text == TB_RepPass.Text) // Verificación de contraseñas //
            {
                ObjUsuario usuario = new ObjUsuario(TB_Nombre.Text, TB_User.Text, TB_Pass.Text, TB_Telefono.Text, DL, H); // Creación del usuario //

                QueryUsuario agregar = new QueryUsuario(instruccion, usuario); // Query para agregar nuevo usuario //
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void BT_LimpDatos_Click(object sender, EventArgs e)
        {
            TB_Nombre.Text = "Nombre";
            TB_User.Text = "Usuario";
            TB_Pass.Text = "Contraseña";
            TB_RepPass.Text = "Repetir Contraseña";
            TB_Telefono.Text = "Teléfono";
            TB_DiasLab.Text = "Días Laborales";
            TB_Horario.Text = "Horario";
        }

        private void TB_Nombre_Click(object sender, EventArgs e)
        {
            TB_Nombre.ForeColor = Color.Black;
            TB_Nombre.Text = "";
        }

        private void TB_User_Click(object sender, EventArgs e)
        {
            TB_User.ForeColor = Color.Black;
            TB_User.Text = "";
        }

        private void TB_Pass_Click(object sender, EventArgs e)
        {
            TB_Pass.ForeColor = Color.Black;
            TB_Pass.Text = "";
        }

        private void TB_RepPass_Click(object sender, EventArgs e)
        {
            TB_RepPass.ForeColor = Color.Black;
            TB_RepPass.Text = "";
        }

        private void TB_Telefono_Click(object sender, EventArgs e)
        {
            TB_Telefono.ForeColor = Color.Black;
            TB_Telefono.Text = "";
        }

        private void TB_DiasLab_Click(object sender, EventArgs e)
        {
            TB_DiasLab.ForeColor = Color.Black;
            TB_DiasLab.Refresh();
        }

        private void TB_Horario_Click(object sender, EventArgs e)
        {
            TB_Horario.ForeColor = Color.Black;
            TB_Horario.Refresh();
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

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void AgregarUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
