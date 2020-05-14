namespace El_Mundo_de_5_Peso
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Ventas = new System.Windows.Forms.DataGridView();
            this.TB_Fecha = new System.Windows.Forms.TextBox();
            this.TB_Usuario = new System.Windows.Forms.TextBox();
            this.BT_Buscar = new System.Windows.Forms.Button();
            this.TB_NumVenta = new System.Windows.Forms.TextBox();
            this.TB_Hora = new System.Windows.Forms.TextBox();
            this.BT_NuevaVenta = new System.Windows.Forms.Button();
            this.BT_ModVenta = new System.Windows.Forms.Button();
            this.BT_MinimizeWindow = new System.Windows.Forms.PictureBox();
            this.BT_CloseWindow = new System.Windows.Forms.PictureBox();
            this.NumVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ventas)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(340, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "VENTAS";
            // 
            // DGV_Ventas
            // 
            this.DGV_Ventas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumVenta,
            this.Usuario,
            this.Productos,
            this.Cantidad,
            this.Total,
            this.Fecha,
            this.Hora,
            this.Detalles});
            this.DGV_Ventas.GridColor = System.Drawing.Color.CornflowerBlue;
            this.DGV_Ventas.Location = new System.Drawing.Point(22, 111);
            this.DGV_Ventas.Name = "DGV_Ventas";
            this.DGV_Ventas.Size = new System.Drawing.Size(754, 409);
            this.DGV_Ventas.TabIndex = 13;
            // 
            // TB_Fecha
            // 
            this.TB_Fecha.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Fecha.Location = new System.Drawing.Point(357, 73);
            this.TB_Fecha.Name = "TB_Fecha";
            this.TB_Fecha.Size = new System.Drawing.Size(169, 27);
            this.TB_Fecha.TabIndex = 24;
            this.TB_Fecha.Text = "Fecha";
            this.TB_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Usuario
            // 
            this.TB_Usuario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Usuario.Location = new System.Drawing.Point(178, 73);
            this.TB_Usuario.Name = "TB_Usuario";
            this.TB_Usuario.Size = new System.Drawing.Size(173, 27);
            this.TB_Usuario.TabIndex = 23;
            this.TB_Usuario.Text = "Usuario";
            this.TB_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_Buscar
            // 
            this.BT_Buscar.AutoSize = true;
            this.BT_Buscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Buscar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Buscar.Location = new System.Drawing.Point(681, 71);
            this.BT_Buscar.Name = "BT_Buscar";
            this.BT_Buscar.Size = new System.Drawing.Size(95, 29);
            this.BT_Buscar.TabIndex = 22;
            this.BT_Buscar.Text = "Buscar";
            this.BT_Buscar.UseVisualStyleBackColor = false;
            // 
            // TB_NumVenta
            // 
            this.TB_NumVenta.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NumVenta.Location = new System.Drawing.Point(23, 73);
            this.TB_NumVenta.Name = "TB_NumVenta";
            this.TB_NumVenta.Size = new System.Drawing.Size(149, 27);
            this.TB_NumVenta.TabIndex = 21;
            this.TB_NumVenta.Text = "Número de Venta";
            this.TB_NumVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Hora
            // 
            this.TB_Hora.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Hora.Location = new System.Drawing.Point(532, 73);
            this.TB_Hora.Name = "TB_Hora";
            this.TB_Hora.Size = new System.Drawing.Size(143, 27);
            this.TB_Hora.TabIndex = 25;
            this.TB_Hora.Text = "Hora";
            this.TB_Hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_NuevaVenta
            // 
            this.BT_NuevaVenta.AutoSize = true;
            this.BT_NuevaVenta.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_NuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_NuevaVenta.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_NuevaVenta.Location = new System.Drawing.Point(459, 536);
            this.BT_NuevaVenta.Name = "BT_NuevaVenta";
            this.BT_NuevaVenta.Size = new System.Drawing.Size(317, 29);
            this.BT_NuevaVenta.TabIndex = 26;
            this.BT_NuevaVenta.Text = "Nueva Venta";
            this.BT_NuevaVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_NuevaVenta.UseVisualStyleBackColor = false;
            this.BT_NuevaVenta.Click += new System.EventHandler(this.BT_NuevaVenta_Click);
            // 
            // BT_ModVenta
            // 
            this.BT_ModVenta.AutoSize = true;
            this.BT_ModVenta.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_ModVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ModVenta.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ModVenta.Location = new System.Drawing.Point(23, 536);
            this.BT_ModVenta.Name = "BT_ModVenta";
            this.BT_ModVenta.Size = new System.Drawing.Size(317, 29);
            this.BT_ModVenta.TabIndex = 27;
            this.BT_ModVenta.Text = "Modificar Venta";
            this.BT_ModVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_ModVenta.UseVisualStyleBackColor = false;
            this.BT_ModVenta.Click += new System.EventHandler(this.BT_ModVenta_Click);
            // 
            // BT_MinimizeWindow
            // 
            this.BT_MinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_MinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("BT_MinimizeWindow.Image")));
            this.BT_MinimizeWindow.Location = new System.Drawing.Point(705, 16);
            this.BT_MinimizeWindow.Name = "BT_MinimizeWindow";
            this.BT_MinimizeWindow.Size = new System.Drawing.Size(33, 33);
            this.BT_MinimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_MinimizeWindow.TabIndex = 29;
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
            this.BT_CloseWindow.TabIndex = 28;
            this.BT_CloseWindow.TabStop = false;
            this.BT_CloseWindow.Click += new System.EventHandler(this.BT_CloseWindow_Click);
            // 
            // NumVenta
            // 
            this.NumVenta.HeaderText = "Número Venta";
            this.NumVenta.Name = "NumVenta";
            this.NumVenta.ReadOnly = true;
            this.NumVenta.Width = 80;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 98;
            // 
            // Productos
            // 
            this.Productos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Productos.HeaderText = "Artículos";
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            this.Productos.Width = 107;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 87;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 90;
            // 
            // Hora
            // 
            this.Hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Detalles
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Detalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.Detalles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detalles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detalles.Text = "Abrir";
            this.Detalles.UseColumnTextForButtonValue = true;
            this.Detalles.Width = 80;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::El_Mundo_de_5_Peso.Properties.Resources._65574304_gradiente_azul_suave_resumen_fondo_oscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.BT_MinimizeWindow);
            this.Controls.Add(this.BT_CloseWindow);
            this.Controls.Add(this.BT_ModVenta);
            this.Controls.Add(this.BT_NuevaVenta);
            this.Controls.Add(this.TB_Hora);
            this.Controls.Add(this.TB_Fecha);
            this.Controls.Add(this.TB_Usuario);
            this.Controls.Add(this.BT_Buscar);
            this.Controls.Add(this.TB_NumVenta);
            this.Controls.Add(this.DGV_Ventas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventass";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ventas_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Ventas;
        private System.Windows.Forms.TextBox TB_Fecha;
        private System.Windows.Forms.TextBox TB_Usuario;
        private System.Windows.Forms.Button BT_Buscar;
        private System.Windows.Forms.TextBox TB_NumVenta;
        private System.Windows.Forms.TextBox TB_Hora;
        private System.Windows.Forms.Button BT_NuevaVenta;
        private System.Windows.Forms.Button BT_ModVenta;
        private System.Windows.Forms.PictureBox BT_MinimizeWindow;
        private System.Windows.Forms.PictureBox BT_CloseWindow;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewButtonColumn Detalles;
    }
}