namespace Producto
{
    partial class AgregarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarArticulo));
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Imagen = new System.Windows.Forms.Label();
            this.PB_Imagen = new System.Windows.Forms.PictureBox();
            this.TB_Descripcion = new System.Windows.Forms.TextBox();
            this.TB_Codigo = new System.Windows.Forms.TextBox();
            this.NUD_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.NUD_Precio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_AgrArt = new System.Windows.Forms.Button();
            this.BT_LimpDatos = new System.Windows.Forms.Button();
            this.BT_MinimizeWindow = new System.Windows.Forms.PictureBox();
            this.BT_CloseWindow = new System.Windows.Forms.PictureBox();
            this.OFD_ArtNuevo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.Location = new System.Drawing.Point(23, 108);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(340, 27);
            this.TB_Nombre.TabIndex = 1;
            this.TB_Nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "ARTICULO NUEVO";
            // 
            // LB_Imagen
            // 
            this.LB_Imagen.AutoSize = true;
            this.LB_Imagen.BackColor = System.Drawing.Color.White;
            this.LB_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Imagen.Enabled = false;
            this.LB_Imagen.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Imagen.Location = new System.Drawing.Point(455, 176);
            this.LB_Imagen.Name = "LB_Imagen";
            this.LB_Imagen.Size = new System.Drawing.Size(81, 21);
            this.LB_Imagen.TabIndex = 8;
            this.LB_Imagen.Text = "IMAGEN";
            // 
            // PB_Imagen
            // 
            this.PB_Imagen.BackColor = System.Drawing.Color.White;
            this.PB_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Imagen.Location = new System.Drawing.Point(383, 75);
            this.PB_Imagen.Name = "PB_Imagen";
            this.PB_Imagen.Size = new System.Drawing.Size(221, 222);
            this.PB_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Imagen.TabIndex = 6;
            this.PB_Imagen.TabStop = false;
            this.PB_Imagen.Click += new System.EventHandler(this.PB_Imagen_Click);
            // 
            // TB_Descripcion
            // 
            this.TB_Descripcion.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Descripcion.Location = new System.Drawing.Point(23, 141);
            this.TB_Descripcion.Multiline = true;
            this.TB_Descripcion.Name = "TB_Descripcion";
            this.TB_Descripcion.Size = new System.Drawing.Size(340, 122);
            this.TB_Descripcion.TabIndex = 12;
            this.TB_Descripcion.Text = "Descripción";
            // 
            // TB_Codigo
            // 
            this.TB_Codigo.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Codigo.Location = new System.Drawing.Point(23, 75);
            this.TB_Codigo.Name = "TB_Codigo";
            this.TB_Codigo.Size = new System.Drawing.Size(340, 27);
            this.TB_Codigo.TabIndex = 13;
            this.TB_Codigo.Text = "Código";
            // 
            // NUD_Cantidad
            // 
            this.NUD_Cantidad.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Cantidad.Location = new System.Drawing.Point(117, 270);
            this.NUD_Cantidad.Name = "NUD_Cantidad";
            this.NUD_Cantidad.Size = new System.Drawing.Size(56, 27);
            this.NUD_Cantidad.TabIndex = 14;
            this.NUD_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NUD_Precio
            // 
            this.NUD_Precio.DecimalPlaces = 2;
            this.NUD_Precio.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Precio.Location = new System.Drawing.Point(279, 270);
            this.NUD_Precio.Name = "NUD_Precio";
            this.NUD_Precio.Size = new System.Drawing.Size(84, 27);
            this.NUD_Precio.TabIndex = 15;
            this.NUD_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantidad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "Precio";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_AgrArt
            // 
            this.BT_AgrArt.AutoSize = true;
            this.BT_AgrArt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_AgrArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_AgrArt.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AgrArt.Location = new System.Drawing.Point(317, 318);
            this.BT_AgrArt.Name = "BT_AgrArt";
            this.BT_AgrArt.Size = new System.Drawing.Size(288, 29);
            this.BT_AgrArt.TabIndex = 27;
            this.BT_AgrArt.Text = "Agregar Artículo";
            this.BT_AgrArt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_AgrArt.UseVisualStyleBackColor = false;
            // 
            // BT_LimpDatos
            // 
            this.BT_LimpDatos.AutoSize = true;
            this.BT_LimpDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BT_LimpDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_LimpDatos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_LimpDatos.Location = new System.Drawing.Point(21, 318);
            this.BT_LimpDatos.Name = "BT_LimpDatos";
            this.BT_LimpDatos.Size = new System.Drawing.Size(287, 29);
            this.BT_LimpDatos.TabIndex = 28;
            this.BT_LimpDatos.Text = "Limpiar Datos";
            this.BT_LimpDatos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_LimpDatos.UseVisualStyleBackColor = false;
            // 
            // BT_MinimizeWindow
            // 
            this.BT_MinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_MinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("BT_MinimizeWindow.Image")));
            this.BT_MinimizeWindow.Location = new System.Drawing.Point(533, 16);
            this.BT_MinimizeWindow.Name = "BT_MinimizeWindow";
            this.BT_MinimizeWindow.Size = new System.Drawing.Size(33, 33);
            this.BT_MinimizeWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_MinimizeWindow.TabIndex = 31;
            this.BT_MinimizeWindow.TabStop = false;
            this.BT_MinimizeWindow.Click += new System.EventHandler(this.BT_MinimizeWindow_Click);
            // 
            // BT_CloseWindow
            // 
            this.BT_CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.BT_CloseWindow.Image = global::El_Mundo_de_5_Peso.Properties.Resources.close_window;
            this.BT_CloseWindow.Location = new System.Drawing.Point(572, 16);
            this.BT_CloseWindow.Name = "BT_CloseWindow";
            this.BT_CloseWindow.Size = new System.Drawing.Size(33, 33);
            this.BT_CloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BT_CloseWindow.TabIndex = 30;
            this.BT_CloseWindow.TabStop = false;
            this.BT_CloseWindow.Click += new System.EventHandler(this.BT_CloseWindow_Click);
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::El_Mundo_de_5_Peso.Properties.Resources._65574304_gradiente_azul_suave_resumen_fondo_oscuro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 365);
            this.Controls.Add(this.BT_MinimizeWindow);
            this.Controls.Add(this.BT_CloseWindow);
            this.Controls.Add(this.BT_LimpDatos);
            this.Controls.Add(this.BT_AgrArt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NUD_Cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NUD_Precio);
            this.Controls.Add(this.TB_Codigo);
            this.Controls.Add(this.TB_Descripcion);
            this.Controls.Add(this.LB_Imagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_Imagen);
            this.Controls.Add(this.TB_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarArticulo";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AgregarArticulo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MinimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BT_CloseWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Imagen;
        private System.Windows.Forms.PictureBox PB_Imagen;
        private System.Windows.Forms.TextBox TB_Descripcion;
        private System.Windows.Forms.TextBox TB_Codigo;
        private System.Windows.Forms.NumericUpDown NUD_Cantidad;
        private System.Windows.Forms.NumericUpDown NUD_Precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_AgrArt;
        private System.Windows.Forms.Button BT_LimpDatos;
        private System.Windows.Forms.PictureBox BT_MinimizeWindow;
        private System.Windows.Forms.PictureBox BT_CloseWindow;
        private System.Windows.Forms.OpenFileDialog OFD_ArtNuevo;
    }
}

