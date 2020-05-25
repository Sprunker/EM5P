namespace El_Mundo_de_5_Peso
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Inventario = new System.Windows.Forms.DataGridView();
            this.BT_BorArt = new System.Windows.Forms.Button();
            this.BT_AgregarNuevo = new System.Windows.Forms.Button();
            this.BT_ModArt = new System.Windows.Forms.Button();
            this.TB_NomArtBusc = new System.Windows.Forms.TextBox();
            this.TB_CodArtBusc = new System.Windows.Forms.TextBox();
            this.BT_Buscar = new System.Windows.Forms.Button();
            this.BT_Agregar = new System.Windows.Forms.Button();
            this.TB_CodArtAgr = new System.Windows.Forms.TextBox();
            this.TB_NomArtAgr = new System.Windows.Forms.TextBox();
            this.TB_CantidadAgr = new System.Windows.Forms.TextBox();
            this.BT_MinimizeWindow = new System.Windows.Forms.PictureBox();
            this.BT_CloseWindow = new System.Windows.Forms.PictureBox();
            this.m5PDBDataSet1 = new El_Mundo_de_5_Peso.M5PDBDataSet1();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new El_Mundo_de_5_Peso.M5PDBDataSet1TableAdapters.ArticuloTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m5PDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "INVENTARIO";
            // 
            // DGV_Inventario
            // 
            this.DGV_Inventario.AutoGenerateColumns = false;
            this.DGV_Inventario.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Inventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.detallesDataGridViewTextBoxColumn,
            this.imagenDataGridViewTextBoxColumn});
            this.DGV_Inventario.DataSource = this.articuloBindingSource;
            this.DGV_Inventario.GridColor = System.Drawing.Color.CornflowerBlue;
            this.DGV_Inventario.Location = new System.Drawing.Point(23, 109);
            this.DGV_Inventario.Name = "DGV_Inventario";
            this.DGV_Inventario.Size = new System.Drawing.Size(1117, 412);
            this.DGV_Inventario.TabIndex = 15;
            // 
            // BT_BorArt
            // 
            this.BT_BorArt.AutoSize = true;
            this.BT_BorArt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_BorArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_BorArt.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_BorArt.Location = new System.Drawing.Point(903, 582);
            this.BT_BorArt.Name = "BT_BorArt";
            this.BT_BorArt.Size = new System.Drawing.Size(238, 29);
            this.BT_BorArt.TabIndex = 27;
            this.BT_BorArt.Text = "Borrar Artículo";
            this.BT_BorArt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_BorArt.UseVisualStyleBackColor = false;
            // 
            // BT_AgregarNuevo
            // 
            this.BT_AgregarNuevo.AutoSize = true;
            this.BT_AgregarNuevo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_AgregarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_AgregarNuevo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AgregarNuevo.Location = new System.Drawing.Point(23, 582);
            this.BT_AgregarNuevo.Name = "BT_AgregarNuevo";
            this.BT_AgregarNuevo.Size = new System.Drawing.Size(238, 29);
            this.BT_AgregarNuevo.TabIndex = 28;
            this.BT_AgregarNuevo.Text = "Agregar Artículo Nuevo";
            this.BT_AgregarNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_AgregarNuevo.UseVisualStyleBackColor = false;
            this.BT_AgregarNuevo.Click += new System.EventHandler(this.BT_AgregarNuevo_Click);
            // 
            // BT_ModArt
            // 
            this.BT_ModArt.AutoSize = true;
            this.BT_ModArt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_ModArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ModArt.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ModArt.Location = new System.Drawing.Point(480, 582);
            this.BT_ModArt.Name = "BT_ModArt";
            this.BT_ModArt.Size = new System.Drawing.Size(238, 29);
            this.BT_ModArt.TabIndex = 29;
            this.BT_ModArt.Text = "Modificar Artículo";
            this.BT_ModArt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_ModArt.UseVisualStyleBackColor = false;
            this.BT_ModArt.Click += new System.EventHandler(this.BT_ModArt_Click);
            // 
            // TB_NomArtBusc
            // 
            this.TB_NomArtBusc.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NomArtBusc.Location = new System.Drawing.Point(352, 70);
            this.TB_NomArtBusc.Name = "TB_NomArtBusc";
            this.TB_NomArtBusc.Size = new System.Drawing.Size(544, 27);
            this.TB_NomArtBusc.TabIndex = 32;
            this.TB_NomArtBusc.Text = "Nombre de Artículo";
            this.TB_NomArtBusc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_CodArtBusc
            // 
            this.TB_CodArtBusc.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CodArtBusc.Location = new System.Drawing.Point(24, 70);
            this.TB_CodArtBusc.Name = "TB_CodArtBusc";
            this.TB_CodArtBusc.Size = new System.Drawing.Size(322, 27);
            this.TB_CodArtBusc.TabIndex = 30;
            this.TB_CodArtBusc.Text = "Código de Artículo";
            this.TB_CodArtBusc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_Buscar
            // 
            this.BT_Buscar.AutoSize = true;
            this.BT_Buscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Buscar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Buscar.Location = new System.Drawing.Point(901, 68);
            this.BT_Buscar.Name = "BT_Buscar";
            this.BT_Buscar.Size = new System.Drawing.Size(238, 29);
            this.BT_Buscar.TabIndex = 33;
            this.BT_Buscar.Text = "Buscar Artículo";
            this.BT_Buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Buscar.UseVisualStyleBackColor = false;
            // 
            // BT_Agregar
            // 
            this.BT_Agregar.AutoSize = true;
            this.BT_Agregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Agregar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Agregar.Location = new System.Drawing.Point(903, 537);
            this.BT_Agregar.Name = "BT_Agregar";
            this.BT_Agregar.Size = new System.Drawing.Size(238, 29);
            this.BT_Agregar.TabIndex = 34;
            this.BT_Agregar.Text = "Agregar Artículos";
            this.BT_Agregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Agregar.UseVisualStyleBackColor = false;
            // 
            // TB_CodArtAgr
            // 
            this.TB_CodArtAgr.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CodArtAgr.Location = new System.Drawing.Point(24, 538);
            this.TB_CodArtAgr.Name = "TB_CodArtAgr";
            this.TB_CodArtAgr.Size = new System.Drawing.Size(303, 27);
            this.TB_CodArtAgr.TabIndex = 35;
            this.TB_CodArtAgr.Text = "Código de Artículo";
            this.TB_CodArtAgr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_NomArtAgr
            // 
            this.TB_NomArtAgr.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NomArtAgr.Location = new System.Drawing.Point(333, 538);
            this.TB_NomArtAgr.Name = "TB_NomArtAgr";
            this.TB_NomArtAgr.Size = new System.Drawing.Size(341, 27);
            this.TB_NomArtAgr.TabIndex = 36;
            this.TB_NomArtAgr.Text = "Nombre de Artículo";
            this.TB_NomArtAgr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_CantidadAgr
            // 
            this.TB_CantidadAgr.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CantidadAgr.Location = new System.Drawing.Point(680, 538);
            this.TB_CantidadAgr.Name = "TB_CantidadAgr";
            this.TB_CantidadAgr.Size = new System.Drawing.Size(217, 27);
            this.TB_CantidadAgr.TabIndex = 37;
            this.TB_CantidadAgr.Text = "Cantidad";
            this.TB_CantidadAgr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_MinimizeWindow
            // 
            this.BT_MinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_MinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("BT_MinimizeWindow.Image")));
            this.BT_MinimizeWindow.Location = new System.Drawing.Point(1068, 16);
            this.BT_MinimizeWindow.Name = "BT_MinimizeWindow";
            this.BT_MinimizeWindow.Size = new System.Drawing.Size(33, 33);
            this.BT_MinimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_MinimizeWindow.TabIndex = 39;
            this.BT_MinimizeWindow.TabStop = false;
            this.BT_MinimizeWindow.Click += new System.EventHandler(this.BT_MinimizeWindow_Click);
            // 
            // BT_CloseWindow
            // 
            this.BT_CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_CloseWindow.Image = global::El_Mundo_de_5_Peso.Properties.Resources.close_window;
            this.BT_CloseWindow.Location = new System.Drawing.Point(1107, 16);
            this.BT_CloseWindow.Name = "BT_CloseWindow";
            this.BT_CloseWindow.Size = new System.Drawing.Size(33, 33);
            this.BT_CloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_CloseWindow.TabIndex = 38;
            this.BT_CloseWindow.TabStop = false;
            this.BT_CloseWindow.Click += new System.EventHandler(this.BT_CloseWindow_Click);
            // 
            // m5PDBDataSet1
            // 
            this.m5PDBDataSet1.DataSetName = "M5PDBDataSet1";
            this.m5PDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.m5PDBDataSet1;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código Art.";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // detallesDataGridViewTextBoxColumn
            // 
            this.detallesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detallesDataGridViewTextBoxColumn.DataPropertyName = "detalles";
            this.detallesDataGridViewTextBoxColumn.HeaderText = "Detalles";
            this.detallesDataGridViewTextBoxColumn.Name = "detallesDataGridViewTextBoxColumn";
            // 
            // imagenDataGridViewTextBoxColumn
            // 
            this.imagenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imagenDataGridViewTextBoxColumn.DataPropertyName = "imagen";
            this.imagenDataGridViewTextBoxColumn.HeaderText = "Imagen";
            this.imagenDataGridViewTextBoxColumn.Name = "imagenDataGridViewTextBoxColumn";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::El_Mundo_de_5_Peso.Properties.Resources._65574304_gradiente_azul_suave_resumen_fondo_oscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1164, 628);
            this.Controls.Add(this.BT_MinimizeWindow);
            this.Controls.Add(this.BT_CloseWindow);
            this.Controls.Add(this.TB_CantidadAgr);
            this.Controls.Add(this.TB_NomArtAgr);
            this.Controls.Add(this.TB_CodArtAgr);
            this.Controls.Add(this.BT_Agregar);
            this.Controls.Add(this.BT_Buscar);
            this.Controls.Add(this.TB_NomArtBusc);
            this.Controls.Add(this.TB_CodArtBusc);
            this.Controls.Add(this.BT_ModArt);
            this.Controls.Add(this.BT_AgregarNuevo);
            this.Controls.Add(this.BT_BorArt);
            this.Controls.Add(this.DGV_Inventario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Inventario_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m5PDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Inventario;
        private System.Windows.Forms.Button BT_BorArt;
        private System.Windows.Forms.Button BT_AgregarNuevo;
        private System.Windows.Forms.Button BT_ModArt;
        private System.Windows.Forms.TextBox TB_NomArtBusc;
        private System.Windows.Forms.TextBox TB_CodArtBusc;
        private System.Windows.Forms.Button BT_Buscar;
        private System.Windows.Forms.Button BT_Agregar;
        private System.Windows.Forms.TextBox TB_CodArtAgr;
        private System.Windows.Forms.TextBox TB_NomArtAgr;
        private System.Windows.Forms.TextBox TB_CantidadAgr;
        private System.Windows.Forms.PictureBox BT_MinimizeWindow;
        private System.Windows.Forms.PictureBox BT_CloseWindow;
        private M5PDBDataSet1 m5PDBDataSet1;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private M5PDBDataSet1TableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenDataGridViewTextBoxColumn;
    }
}