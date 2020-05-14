namespace El_Mundo_de_5_Peso
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TB_User = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.BT_Ingresar = new System.Windows.Forms.Button();
            this.BT_CloseWindow = new System.Windows.Forms.PictureBox();
            this.BT_MinimizeWindow = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_User
            // 
            this.TB_User.BackColor = System.Drawing.SystemColors.Window;
            this.TB_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_User.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_User.Location = new System.Drawing.Point(79, 187);
            this.TB_User.Name = "TB_User";
            this.TB_User.Size = new System.Drawing.Size(163, 33);
            this.TB_User.TabIndex = 0;
            this.TB_User.Text = "Usuario";
            this.TB_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_User.Click += new System.EventHandler(this.TB_User_Click);
            this.TB_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_User_KeyPress);
            // 
            // TB_Password
            // 
            this.TB_Password.BackColor = System.Drawing.SystemColors.Window;
            this.TB_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Password.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(79, 240);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(163, 30);
            this.TB_Password.TabIndex = 1;
            this.TB_Password.Text = "Contraseña";
            this.TB_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_Password.Click += new System.EventHandler(this.TB_Password_Click);
            this.TB_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Password_KeyPress);
            // 
            // BT_Ingresar
            // 
            this.BT_Ingresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BT_Ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BT_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Ingresar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Ingresar.Location = new System.Drawing.Point(118, 294);
            this.BT_Ingresar.Name = "BT_Ingresar";
            this.BT_Ingresar.Size = new System.Drawing.Size(84, 32);
            this.BT_Ingresar.TabIndex = 2;
            this.BT_Ingresar.Text = "Ingresar";
            this.BT_Ingresar.UseVisualStyleBackColor = false;
            this.BT_Ingresar.Click += new System.EventHandler(this.BT_Ingresar_Click);
            // 
            // BT_CloseWindow
            // 
            this.BT_CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_CloseWindow.Image = global::El_Mundo_de_5_Peso.Properties.Resources.close_window;
            this.BT_CloseWindow.Location = new System.Drawing.Point(275, 12);
            this.BT_CloseWindow.Name = "BT_CloseWindow";
            this.BT_CloseWindow.Size = new System.Drawing.Size(33, 33);
            this.BT_CloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_CloseWindow.TabIndex = 3;
            this.BT_CloseWindow.TabStop = false;
            this.BT_CloseWindow.Click += new System.EventHandler(this.BT_CloseWindow_Click);
            // 
            // BT_MinimizeWindow
            // 
            this.BT_MinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_MinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("BT_MinimizeWindow.Image")));
            this.BT_MinimizeWindow.Location = new System.Drawing.Point(236, 12);
            this.BT_MinimizeWindow.Name = "BT_MinimizeWindow";
            this.BT_MinimizeWindow.Size = new System.Drawing.Size(33, 33);
            this.BT_MinimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_MinimizeWindow.TabIndex = 4;
            this.BT_MinimizeWindow.TabStop = false;
            this.BT_MinimizeWindow.Click += new System.EventHandler(this.BT_MinimizeWindow_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::El_Mundo_de_5_Peso.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.BT_MinimizeWindow);
            this.Controls.Add(this.BT_CloseWindow);
            this.Controls.Add(this.BT_Ingresar);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_User;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Button BT_Ingresar;
        private System.Windows.Forms.PictureBox BT_CloseWindow;
        private System.Windows.Forms.PictureBox BT_MinimizeWindow;
        private System.Windows.Forms.Timer timer1;
    }
}

