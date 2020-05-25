namespace El_Mundo_de_5_Peso
{
    partial class Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.LB_Titulo = new System.Windows.Forms.Label();
            this.DGV_Venta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TB_NomPro = new System.Windows.Forms.TextBox();
            this.BT_Agregar = new System.Windows.Forms.Button();
            this.TB_CodProd = new System.Windows.Forms.TextBox();
            this.TB_Cantidad = new System.Windows.Forms.TextBox();
            this.BT_MinimizeWindow = new System.Windows.Forms.PictureBox();
            this.BT_CloseWindow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Venta)).BeginInit();
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
            this.LB_Titulo.Location = new System.Drawing.Point(347, 16);
            this.LB_Titulo.Name = "LB_Titulo";
            this.LB_Titulo.Size = new System.Drawing.Size(115, 37);
            this.LB_Titulo.TabIndex = 13;
            this.LB_Titulo.Text = "VENTA";
            // 
            // DGV_Venta
            // 
            this.DGV_Venta.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Venta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.PrecioU,
            this.Total,
            this.Eliminar});
            this.DGV_Venta.GridColor = System.Drawing.Color.CornflowerBlue;
            this.DGV_Venta.Location = new System.Drawing.Point(23, 72);
            this.DGV_Venta.Name = "DGV_Venta";
            this.DGV_Venta.Size = new System.Drawing.Size(754, 438);
            this.DGV_Venta.TabIndex = 14;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.HeaderText = "Código A.";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioU
            // 
            this.PrecioU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioU.HeaderText = "Precio U.";
            this.PrecioU.Name = "PrecioU";
            this.PrecioU.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 90;
            // 
            // TB_NomPro
            // 
            this.TB_NomPro.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NomPro.Location = new System.Drawing.Point(209, 532);
            this.TB_NomPro.Name = "TB_NomPro";
            this.TB_NomPro.Size = new System.Drawing.Size(210, 27);
            this.TB_NomPro.TabIndex = 26;
            this.TB_NomPro.Text = "Nombre de Artículo";
            this.TB_NomPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_Agregar
            // 
            this.BT_Agregar.AutoSize = true;
            this.BT_Agregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Agregar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Agregar.Location = new System.Drawing.Point(568, 531);
            this.BT_Agregar.Name = "BT_Agregar";
            this.BT_Agregar.Size = new System.Drawing.Size(209, 29);
            this.BT_Agregar.TabIndex = 25;
            this.BT_Agregar.Text = "Agregar";
            this.BT_Agregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Agregar.UseVisualStyleBackColor = false;
            this.BT_Agregar.Click += new System.EventHandler(this.BT_Agregar_Click);
            // 
            // TB_CodProd
            // 
            this.TB_CodProd.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CodProd.Location = new System.Drawing.Point(23, 532);
            this.TB_CodProd.Name = "TB_CodProd";
            this.TB_CodProd.Size = new System.Drawing.Size(180, 27);
            this.TB_CodProd.TabIndex = 24;
            this.TB_CodProd.Text = "Código de Artículo";
            this.TB_CodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_Cantidad
            // 
            this.TB_Cantidad.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Cantidad.Location = new System.Drawing.Point(425, 532);
            this.TB_Cantidad.Name = "TB_Cantidad";
            this.TB_Cantidad.Size = new System.Drawing.Size(137, 27);
            this.TB_Cantidad.TabIndex = 27;
            this.TB_Cantidad.Text = "Cantidad";
            this.TB_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::El_Mundo_de_5_Peso.Properties.Resources._65574304_gradiente_azul_suave_resumen_fondo_oscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.BT_MinimizeWindow);
            this.Controls.Add(this.BT_CloseWindow);
            this.Controls.Add(this.TB_Cantidad);
            this.Controls.Add(this.TB_NomPro);
            this.Controls.Add(this.BT_Agregar);
            this.Controls.Add(this.TB_CodProd);
            this.Controls.Add(this.DGV_Venta);
            this.Controls.Add(this.LB_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Venta_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Titulo;
        private System.Windows.Forms.DataGridView DGV_Venta;
        private System.Windows.Forms.TextBox TB_NomPro;
        private System.Windows.Forms.Button BT_Agregar;
        private System.Windows.Forms.TextBox TB_CodProd;
        private System.Windows.Forms.TextBox TB_Cantidad;
        private System.Windows.Forms.PictureBox BT_MinimizeWindow;
        private System.Windows.Forms.PictureBox BT_CloseWindow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}