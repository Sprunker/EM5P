namespace El_Mundo_de_5_Peso
{
    partial class Usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Usuarios = new System.Windows.Forms.DataGridView();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_CodigoUser = new System.Windows.Forms.TextBox();
            this.TB_Usuario = new System.Windows.Forms.TextBox();
            this.BT_Buscar = new System.Windows.Forms.Button();
            this.BT_AgrUser = new System.Windows.Forms.Button();
            this.BT_BorUser = new System.Windows.Forms.Button();
            this.BT_ModUser = new System.Windows.Forms.Button();
            this.BT_MinimizeWindow = new System.Windows.Forms.PictureBox();
            this.BT_CloseWindow = new System.Windows.Forms.PictureBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasLaborales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "LISTA DE USUARIOS";
            // 
            // DGV_Usuarios
            // 
            this.DGV_Usuarios.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Usuario,
            this.DiasLaborales,
            this.Horario,
            this.NumTelefono});
            this.DGV_Usuarios.GridColor = System.Drawing.Color.CornflowerBlue;
            this.DGV_Usuarios.Location = new System.Drawing.Point(22, 111);
            this.DGV_Usuarios.Name = "DGV_Usuarios";
            this.DGV_Usuarios.Size = new System.Drawing.Size(754, 409);
            this.DGV_Usuarios.TabIndex = 12;
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.Location = new System.Drawing.Point(178, 73);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(241, 27);
            this.TB_Nombre.TabIndex = 15;
            this.TB_Nombre.Text = "Nombre";
            this.TB_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_CodigoUser
            // 
            this.TB_CodigoUser.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CodigoUser.Location = new System.Drawing.Point(23, 73);
            this.TB_CodigoUser.Name = "TB_CodigoUser";
            this.TB_CodigoUser.Size = new System.Drawing.Size(149, 27);
            this.TB_CodigoUser.TabIndex = 13;
            this.TB_CodigoUser.Text = "Código";
            this.TB_CodigoUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Usuario
            // 
            this.TB_Usuario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Usuario.Location = new System.Drawing.Point(425, 73);
            this.TB_Usuario.Name = "TB_Usuario";
            this.TB_Usuario.Size = new System.Drawing.Size(250, 27);
            this.TB_Usuario.TabIndex = 16;
            this.TB_Usuario.Text = "Usuario";
            this.TB_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_Buscar
            // 
            this.BT_Buscar.AutoSize = true;
            this.BT_Buscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Buscar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Buscar.Location = new System.Drawing.Point(681, 72);
            this.BT_Buscar.Name = "BT_Buscar";
            this.BT_Buscar.Size = new System.Drawing.Size(95, 29);
            this.BT_Buscar.TabIndex = 23;
            this.BT_Buscar.Text = "Buscar";
            this.BT_Buscar.UseVisualStyleBackColor = false;
            // 
            // BT_AgrUser
            // 
            this.BT_AgrUser.AutoSize = true;
            this.BT_AgrUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_AgrUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_AgrUser.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AgrUser.Location = new System.Drawing.Point(23, 536);
            this.BT_AgrUser.Name = "BT_AgrUser";
            this.BT_AgrUser.Size = new System.Drawing.Size(225, 29);
            this.BT_AgrUser.TabIndex = 28;
            this.BT_AgrUser.Text = "Agregar Usuario";
            this.BT_AgrUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_AgrUser.UseVisualStyleBackColor = false;
            this.BT_AgrUser.Click += new System.EventHandler(this.BT_AgrUser_Click);
            // 
            // BT_BorUser
            // 
            this.BT_BorUser.AutoSize = true;
            this.BT_BorUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_BorUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_BorUser.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_BorUser.Location = new System.Drawing.Point(551, 536);
            this.BT_BorUser.Name = "BT_BorUser";
            this.BT_BorUser.Size = new System.Drawing.Size(225, 29);
            this.BT_BorUser.TabIndex = 29;
            this.BT_BorUser.Text = "Borrar Usuario";
            this.BT_BorUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_BorUser.UseVisualStyleBackColor = false;
            // 
            // BT_ModUser
            // 
            this.BT_ModUser.AutoSize = true;
            this.BT_ModUser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_ModUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ModUser.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ModUser.Location = new System.Drawing.Point(288, 536);
            this.BT_ModUser.Name = "BT_ModUser";
            this.BT_ModUser.Size = new System.Drawing.Size(225, 29);
            this.BT_ModUser.TabIndex = 30;
            this.BT_ModUser.Text = "Modificar Usuario";
            this.BT_ModUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_ModUser.UseVisualStyleBackColor = false;
            this.BT_ModUser.Click += new System.EventHandler(this.BT_ModUser_Click);
            // 
            // BT_MinimizeWindow
            // 
            this.BT_MinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_MinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("BT_MinimizeWindow.Image")));
            this.BT_MinimizeWindow.Location = new System.Drawing.Point(705, 16);
            this.BT_MinimizeWindow.Name = "BT_MinimizeWindow";
            this.BT_MinimizeWindow.Size = new System.Drawing.Size(33, 33);
            this.BT_MinimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_MinimizeWindow.TabIndex = 32;
            this.BT_MinimizeWindow.TabStop = false;
            this.BT_MinimizeWindow.Click += new System.EventHandler(this.BT_MinimizeWindow_Click);
            // 
            // BT_CloseWindow
            // 
            this.BT_CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_CloseWindow.Image = global::El_Mundo_de_5_Peso.Properties.Resources.close_window;
            this.BT_CloseWindow.Location = new System.Drawing.Point(744, 16);
            this.BT_CloseWindow.Name = "BT_CloseWindow";
            this.BT_CloseWindow.Size = new System.Drawing.Size(33, 33);
            this.BT_CloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_CloseWindow.TabIndex = 31;
            this.BT_CloseWindow.TabStop = false;
            this.BT_CloseWindow.Click += new System.EventHandler(this.BT_CloseWindow_Click);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 95;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 218;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Usuario.DefaultCellStyle = dataGridViewCellStyle4;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 98;
            // 
            // DiasLaborales
            // 
            this.DiasLaborales.HeaderText = "Dias Laborales";
            this.DiasLaborales.Name = "DiasLaborales";
            this.DiasLaborales.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // NumTelefono
            // 
            this.NumTelefono.HeaderText = "Número Telefónico";
            this.NumTelefono.Name = "NumTelefono";
            this.NumTelefono.ReadOnly = true;
            this.NumTelefono.Width = 101;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::El_Mundo_de_5_Peso.Properties.Resources._65574304_gradiente_azul_suave_resumen_fondo_oscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.BT_MinimizeWindow);
            this.Controls.Add(this.BT_CloseWindow);
            this.Controls.Add(this.BT_ModUser);
            this.Controls.Add(this.BT_BorUser);
            this.Controls.Add(this.BT_AgrUser);
            this.Controls.Add(this.BT_Buscar);
            this.Controls.Add(this.TB_Usuario);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.TB_CodigoUser);
            this.Controls.Add(this.DGV_Usuarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Usuarios_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Usuarios;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_CodigoUser;
        private System.Windows.Forms.TextBox TB_Usuario;
        private System.Windows.Forms.Button BT_Buscar;
        private System.Windows.Forms.Button BT_AgrUser;
        private System.Windows.Forms.Button BT_BorUser;
        private System.Windows.Forms.Button BT_ModUser;
        private System.Windows.Forms.PictureBox BT_MinimizeWindow;
        private System.Windows.Forms.PictureBox BT_CloseWindow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasLaborales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumTelefono;
    }
}