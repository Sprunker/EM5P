namespace El_Mundo_de_5_Peso
{
    partial class AdminUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUI));
            this.BT_Inventario = new System.Windows.Forms.Button();
            this.BT_AdmUsers = new System.Windows.Forms.Button();
            this.LB_NameUser = new System.Windows.Forms.Label();
            this.BT_CerrarSesion = new System.Windows.Forms.Button();
            this.BT_Ventas = new System.Windows.Forms.Button();
            this.BT_CloseWindow = new System.Windows.Forms.PictureBox();
            this.BT_Opciones = new System.Windows.Forms.PictureBox();
            this.BT_MinimizeWindow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_Opciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Inventario
            // 
            this.BT_Inventario.AutoSize = true;
            this.BT_Inventario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_Inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BT_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Inventario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Inventario.Location = new System.Drawing.Point(76, 213);
            this.BT_Inventario.Name = "BT_Inventario";
            this.BT_Inventario.Size = new System.Drawing.Size(166, 32);
            this.BT_Inventario.TabIndex = 3;
            this.BT_Inventario.Text = "Inventario";
            this.BT_Inventario.UseVisualStyleBackColor = false;
            this.BT_Inventario.Click += new System.EventHandler(this.BT_Inventario_Click);
            // 
            // BT_AdmUsers
            // 
            this.BT_AdmUsers.AutoSize = true;
            this.BT_AdmUsers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_AdmUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BT_AdmUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AdmUsers.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AdmUsers.Location = new System.Drawing.Point(76, 251);
            this.BT_AdmUsers.Name = "BT_AdmUsers";
            this.BT_AdmUsers.Size = new System.Drawing.Size(166, 32);
            this.BT_AdmUsers.TabIndex = 4;
            this.BT_AdmUsers.Text = "Administrar Usuarios";
            this.BT_AdmUsers.UseVisualStyleBackColor = false;
            this.BT_AdmUsers.Click += new System.EventHandler(this.BT_AdmUsers_Click);
            // 
            // LB_NameUser
            // 
            this.LB_NameUser.AutoSize = true;
            this.LB_NameUser.BackColor = System.Drawing.Color.Transparent;
            this.LB_NameUser.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NameUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_NameUser.Location = new System.Drawing.Point(11, 12);
            this.LB_NameUser.Name = "LB_NameUser";
            this.LB_NameUser.Size = new System.Drawing.Size(70, 19);
            this.LB_NameUser.TabIndex = 6;
            this.LB_NameUser.Text = "Usuario";
            this.LB_NameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_CerrarSesion
            // 
            this.BT_CerrarSesion.AutoSize = true;
            this.BT_CerrarSesion.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_CerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BT_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CerrarSesion.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CerrarSesion.Location = new System.Drawing.Point(104, 305);
            this.BT_CerrarSesion.Name = "BT_CerrarSesion";
            this.BT_CerrarSesion.Size = new System.Drawing.Size(107, 28);
            this.BT_CerrarSesion.TabIndex = 7;
            this.BT_CerrarSesion.Text = "Cerrar Sesión";
            this.BT_CerrarSesion.UseVisualStyleBackColor = false;
            this.BT_CerrarSesion.Click += new System.EventHandler(this.BT_CerrarSesion_Click);
            // 
            // BT_Ventas
            // 
            this.BT_Ventas.AutoSize = true;
            this.BT_Ventas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BT_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Ventas.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Ventas.Location = new System.Drawing.Point(76, 175);
            this.BT_Ventas.Name = "BT_Ventas";
            this.BT_Ventas.Size = new System.Drawing.Size(166, 32);
            this.BT_Ventas.TabIndex = 8;
            this.BT_Ventas.Text = "Ventas";
            this.BT_Ventas.UseVisualStyleBackColor = false;
            this.BT_Ventas.Click += new System.EventHandler(this.BT_Ventas_Click);
            // 
            // BT_CloseWindow
            // 
            this.BT_CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_CloseWindow.Image = global::El_Mundo_de_5_Peso.Properties.Resources.close_window;
            this.BT_CloseWindow.Location = new System.Drawing.Point(275, 12);
            this.BT_CloseWindow.Name = "BT_CloseWindow";
            this.BT_CloseWindow.Size = new System.Drawing.Size(33, 33);
            this.BT_CloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_CloseWindow.TabIndex = 9;
            this.BT_CloseWindow.TabStop = false;
            this.BT_CloseWindow.Click += new System.EventHandler(this.BT_CloseWindow_Click);
            // 
            // BT_Opciones
            // 
            this.BT_Opciones.BackColor = System.Drawing.Color.Transparent;
            this.BT_Opciones.Image = global::El_Mundo_de_5_Peso.Properties.Resources.gear;
            this.BT_Opciones.Location = new System.Drawing.Point(275, 405);
            this.BT_Opciones.Name = "BT_Opciones";
            this.BT_Opciones.Size = new System.Drawing.Size(33, 33);
            this.BT_Opciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_Opciones.TabIndex = 10;
            this.BT_Opciones.TabStop = false;
            this.BT_Opciones.Click += new System.EventHandler(this.BT_Opciones_Click);
            // 
            // BT_MinimizeWindow
            // 
            this.BT_MinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_MinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("BT_MinimizeWindow.Image")));
            this.BT_MinimizeWindow.Location = new System.Drawing.Point(236, 12);
            this.BT_MinimizeWindow.Name = "BT_MinimizeWindow";
            this.BT_MinimizeWindow.Size = new System.Drawing.Size(33, 33);
            this.BT_MinimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_MinimizeWindow.TabIndex = 11;
            this.BT_MinimizeWindow.TabStop = false;
            this.BT_MinimizeWindow.Click += new System.EventHandler(this.BT_MinimizeWindow_Click);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::El_Mundo_de_5_Peso.Properties.Resources.Fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.BT_MinimizeWindow);
            this.Controls.Add(this.BT_Opciones);
            this.Controls.Add(this.BT_CloseWindow);
            this.Controls.Add(this.BT_Ventas);
            this.Controls.Add(this.BT_CerrarSesion);
            this.Controls.Add(this.LB_NameUser);
            this.Controls.Add(this.BT_AdmUsers);
            this.Controls.Add(this.BT_Inventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUI";
            this.Text = "AdminUI";
            this.Load += new System.EventHandler(this.AdminUI_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminUI_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_Opciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Inventario;
        private System.Windows.Forms.Button BT_AdmUsers;
        private System.Windows.Forms.Label LB_NameUser;
        private System.Windows.Forms.Button BT_CerrarSesion;
        private System.Windows.Forms.Button BT_Ventas;
        private System.Windows.Forms.PictureBox BT_CloseWindow;
        private System.Windows.Forms.PictureBox BT_Opciones;
        private System.Windows.Forms.PictureBox BT_MinimizeWindow;
    }
}