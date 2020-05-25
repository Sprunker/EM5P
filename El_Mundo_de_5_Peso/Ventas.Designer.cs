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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Ventas = new System.Windows.Forms.DataGridView();
            this.numVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m5PDBDataSet2 = new El_Mundo_de_5_Peso.M5PDBDataSet2();
            this.TB_Fecha = new System.Windows.Forms.TextBox();
            this.TB_Usuario = new System.Windows.Forms.TextBox();
            this.BT_Buscar = new System.Windows.Forms.Button();
            this.TB_NumVenta = new System.Windows.Forms.TextBox();
            this.TB_Hora = new System.Windows.Forms.TextBox();
            this.BT_NuevaVenta = new System.Windows.Forms.Button();
            this.BT_ModVenta = new System.Windows.Forms.Button();
            this.BT_MinimizeWindow = new System.Windows.Forms.PictureBox();
            this.BT_CloseWindow = new System.Windows.Forms.PictureBox();
            this.BT_CancelarVenta = new System.Windows.Forms.Button();
            this.ventaTableAdapter = new El_Mundo_de_5_Peso.M5PDBDataSet2TableAdapters.VentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m5PDBDataSet2)).BeginInit();
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
            this.DGV_Ventas.AutoGenerateColumns = false;
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
            this.numVentaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.articulosDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.DGV_Ventas.DataSource = this.ventaBindingSource;
            this.DGV_Ventas.GridColor = System.Drawing.Color.CornflowerBlue;
            this.DGV_Ventas.Location = new System.Drawing.Point(22, 111);
            this.DGV_Ventas.Name = "DGV_Ventas";
            this.DGV_Ventas.Size = new System.Drawing.Size(754, 409);
            this.DGV_Ventas.TabIndex = 13;
            // 
            // numVentaDataGridViewTextBoxColumn
            // 
            this.numVentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numVentaDataGridViewTextBoxColumn.DataPropertyName = "numVenta";
            this.numVentaDataGridViewTextBoxColumn.HeaderText = "Número Venta";
            this.numVentaDataGridViewTextBoxColumn.Name = "numVentaDataGridViewTextBoxColumn";
            this.numVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // articulosDataGridViewTextBoxColumn
            // 
            this.articulosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.articulosDataGridViewTextBoxColumn.DataPropertyName = "articulos";
            this.articulosDataGridViewTextBoxColumn.HeaderText = "Artículos";
            this.articulosDataGridViewTextBoxColumn.Name = "articulosDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Venta";
            this.ventaBindingSource.DataSource = this.m5PDBDataSet2;
            // 
            // m5PDBDataSet2
            // 
            this.m5PDBDataSet2.DataSetName = "M5PDBDataSet2";
            this.m5PDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.BT_NuevaVenta.Location = new System.Drawing.Point(23, 536);
            this.BT_NuevaVenta.Name = "BT_NuevaVenta";
            this.BT_NuevaVenta.Size = new System.Drawing.Size(251, 29);
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
            this.BT_ModVenta.Location = new System.Drawing.Point(281, 536);
            this.BT_ModVenta.Name = "BT_ModVenta";
            this.BT_ModVenta.Size = new System.Drawing.Size(245, 29);
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
            // BT_CancelarVenta
            // 
            this.BT_CancelarVenta.AutoSize = true;
            this.BT_CancelarVenta.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_CancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_CancelarVenta.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CancelarVenta.Location = new System.Drawing.Point(533, 536);
            this.BT_CancelarVenta.Name = "BT_CancelarVenta";
            this.BT_CancelarVenta.Size = new System.Drawing.Size(244, 29);
            this.BT_CancelarVenta.TabIndex = 30;
            this.BT_CancelarVenta.Text = "Cancelar Venta";
            this.BT_CancelarVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_CancelarVenta.UseVisualStyleBackColor = false;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::El_Mundo_de_5_Peso.Properties.Resources._65574304_gradiente_azul_suave_resumen_fondo_oscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.BT_CancelarVenta);
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
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m5PDBDataSet2)).EndInit();
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
        private System.Windows.Forms.Button BT_CancelarVenta;
        private M5PDBDataSet2 m5PDBDataSet2;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private M5PDBDataSet2TableAdapters.VentaTableAdapter ventaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}