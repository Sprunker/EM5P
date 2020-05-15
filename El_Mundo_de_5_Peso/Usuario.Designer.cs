namespace El_Mundo_de_5_Peso
{
    partial class Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.LB_Titulo = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_User = new System.Windows.Forms.TextBox();
            this.TB_Pass = new System.Windows.Forms.TextBox();
            this.TB_RepPass = new System.Windows.Forms.TextBox();
            this.TB_Telefono = new System.Windows.Forms.TextBox();
            this.BT_AgrUser = new System.Windows.Forms.Button();
            this.BT_LimpDatos = new System.Windows.Forms.Button();
            this.BT_MinimizeWindow = new System.Windows.Forms.PictureBox();
            this.BT_CloseWindow = new System.Windows.Forms.PictureBox();
            this.TB_DiasLab = new System.Windows.Forms.ComboBox();
            this.TB_Horario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Titulo
            // 
            this.LB_Titulo.AutoSize = true;
            this.LB_Titulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.LB_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Titulo.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titulo.Location = new System.Drawing.Point(76, 28);
            this.LB_Titulo.Name = "LB_Titulo";
            this.LB_Titulo.Size = new System.Drawing.Size(270, 37);
            this.LB_Titulo.TabIndex = 15;
            this.LB_Titulo.Text = "NUEVO USUARIO";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.Location = new System.Drawing.Point(37, 92);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(340, 27);
            this.TB_Nombre.TabIndex = 14;
            this.TB_Nombre.Text = "Nombre";
            this.TB_Nombre.Click += new System.EventHandler(this.TB_Nombre_Click);
            // 
            // TB_User
            // 
            this.TB_User.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_User.Location = new System.Drawing.Point(37, 125);
            this.TB_User.Name = "TB_User";
            this.TB_User.Size = new System.Drawing.Size(340, 27);
            this.TB_User.TabIndex = 17;
            this.TB_User.Text = "Usuario";
            this.TB_User.Click += new System.EventHandler(this.TB_User_Click);
            // 
            // TB_Pass
            // 
            this.TB_Pass.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Pass.Location = new System.Drawing.Point(37, 158);
            this.TB_Pass.Name = "TB_Pass";
            this.TB_Pass.Size = new System.Drawing.Size(340, 27);
            this.TB_Pass.TabIndex = 18;
            this.TB_Pass.Text = "Contraseña";
            this.TB_Pass.Click += new System.EventHandler(this.TB_Pass_Click);
            // 
            // TB_RepPass
            // 
            this.TB_RepPass.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_RepPass.Location = new System.Drawing.Point(37, 191);
            this.TB_RepPass.Name = "TB_RepPass";
            this.TB_RepPass.Size = new System.Drawing.Size(340, 27);
            this.TB_RepPass.TabIndex = 19;
            this.TB_RepPass.Text = "Repetir Contraseña";
            this.TB_RepPass.Click += new System.EventHandler(this.TB_RepPass_Click);
            // 
            // TB_Telefono
            // 
            this.TB_Telefono.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Telefono.Location = new System.Drawing.Point(37, 224);
            this.TB_Telefono.Name = "TB_Telefono";
            this.TB_Telefono.Size = new System.Drawing.Size(340, 27);
            this.TB_Telefono.TabIndex = 20;
            this.TB_Telefono.Text = "Teléfono";
            this.TB_Telefono.Click += new System.EventHandler(this.TB_Telefono_Click);
            // 
            // BT_AgrUser
            // 
            this.BT_AgrUser.AutoSize = true;
            this.BT_AgrUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_AgrUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_AgrUser.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AgrUser.Location = new System.Drawing.Point(220, 342);
            this.BT_AgrUser.Name = "BT_AgrUser";
            this.BT_AgrUser.Size = new System.Drawing.Size(157, 29);
            this.BT_AgrUser.TabIndex = 29;
            this.BT_AgrUser.Text = "Agregar Usuario";
            this.BT_AgrUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_AgrUser.UseVisualStyleBackColor = false;
            this.BT_AgrUser.Click += new System.EventHandler(this.BT_AgrUser_Click);
            // 
            // BT_LimpDatos
            // 
            this.BT_LimpDatos.AutoSize = true;
            this.BT_LimpDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_LimpDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_LimpDatos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_LimpDatos.Location = new System.Drawing.Point(37, 342);
            this.BT_LimpDatos.Name = "BT_LimpDatos";
            this.BT_LimpDatos.Size = new System.Drawing.Size(157, 29);
            this.BT_LimpDatos.TabIndex = 30;
            this.BT_LimpDatos.Text = "Limpiar Datos";
            this.BT_LimpDatos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_LimpDatos.UseVisualStyleBackColor = false;
            this.BT_LimpDatos.Click += new System.EventHandler(this.BT_LimpDatos_Click);
            // 
            // BT_MinimizeWindow
            // 
            this.BT_MinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_MinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("BT_MinimizeWindow.Image")));
            this.BT_MinimizeWindow.Location = new System.Drawing.Point(366, 5);
            this.BT_MinimizeWindow.Name = "BT_MinimizeWindow";
            this.BT_MinimizeWindow.Size = new System.Drawing.Size(20, 20);
            this.BT_MinimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_MinimizeWindow.TabIndex = 44;
            this.BT_MinimizeWindow.TabStop = false;
            this.BT_MinimizeWindow.Click += new System.EventHandler(this.BT_MinimizeWindow_Click);
            // 
            // BT_CloseWindow
            // 
            this.BT_CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_CloseWindow.Image = global::El_Mundo_de_5_Peso.Properties.Resources.close_window;
            this.BT_CloseWindow.Location = new System.Drawing.Point(388, 5);
            this.BT_CloseWindow.Name = "BT_CloseWindow";
            this.BT_CloseWindow.Size = new System.Drawing.Size(20, 20);
            this.BT_CloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_CloseWindow.TabIndex = 43;
            this.BT_CloseWindow.TabStop = false;
            this.BT_CloseWindow.Click += new System.EventHandler(this.BT_CloseWindow_Click);
            // 
            // TB_DiasLab
            // 
            this.TB_DiasLab.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_DiasLab.FormattingEnabled = true;
            this.TB_DiasLab.Items.AddRange(new object[] {
            "Entre Semana",
            "Fines de Semana"});
            this.TB_DiasLab.Location = new System.Drawing.Point(37, 257);
            this.TB_DiasLab.Name = "TB_DiasLab";
            this.TB_DiasLab.Size = new System.Drawing.Size(340, 27);
            this.TB_DiasLab.TabIndex = 45;
            this.TB_DiasLab.Text = "Días Laborales";
            this.TB_DiasLab.Click += new System.EventHandler(this.TB_DiasLab_Click);
            // 
            // TB_Horario
            // 
            this.TB_Horario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Horario.FormattingEnabled = true;
            this.TB_Horario.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino"});
            this.TB_Horario.Location = new System.Drawing.Point(37, 290);
            this.TB_Horario.Name = "TB_Horario";
            this.TB_Horario.Size = new System.Drawing.Size(340, 27);
            this.TB_Horario.TabIndex = 46;
            this.TB_Horario.Text = "Horario";
            this.TB_Horario.Click += new System.EventHandler(this.TB_Horario_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::El_Mundo_de_5_Peso.Properties.Resources._65574304_gradiente_azul_suave_resumen_fondo_oscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 400);
            this.Controls.Add(this.TB_Horario);
            this.Controls.Add(this.TB_DiasLab);
            this.Controls.Add(this.BT_MinimizeWindow);
            this.Controls.Add(this.BT_CloseWindow);
            this.Controls.Add(this.BT_LimpDatos);
            this.Controls.Add(this.BT_AgrUser);
            this.Controls.Add(this.TB_Telefono);
            this.Controls.Add(this.TB_RepPass);
            this.Controls.Add(this.TB_Pass);
            this.Controls.Add(this.TB_User);
            this.Controls.Add(this.LB_Titulo);
            this.Controls.Add(this.TB_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuario";
            this.Text = "AgregarUsuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AgregarUsuario_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Titulo;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_User;
        private System.Windows.Forms.TextBox TB_Pass;
        private System.Windows.Forms.TextBox TB_RepPass;
        private System.Windows.Forms.TextBox TB_Telefono;
        private System.Windows.Forms.Button BT_AgrUser;
        private System.Windows.Forms.Button BT_LimpDatos;
        private System.Windows.Forms.PictureBox BT_MinimizeWindow;
        private System.Windows.Forms.PictureBox BT_CloseWindow;
        private System.Windows.Forms.ComboBox TB_DiasLab;
        private System.Windows.Forms.ComboBox TB_Horario;
    }
}