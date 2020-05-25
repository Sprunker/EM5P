using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using El_Mundo_de_5_Peso;

namespace Producto
{
    public partial class AgregarArticulo : Form
    {
        string mod;
        int idArt;
        bool E = true;
        string imagen;

        public AgregarArticulo(string mod, int idArt)
        {
            InitializeComponent();

            this.mod = mod;

            if (mod == "agregar")
            {
                // Agregar propiedades //
                LB_Titulo.Location = new Point(160, 16);
                LB_Titulo.Text = "ARTICULO NUEVO";
                BT_AgrArt.Text = "Agregar Artículo";

                BT_AgrArt.Click += new System.EventHandler(BT_AgrArt_Click);
            }
            else if (mod == "modificar")
            {
                // Agregar propiedades //
                LB_Titulo.Location = new Point(137, 16);
                LB_Titulo.Text = "MODIFICAR ARTICULO";
                BT_AgrArt.Text = "Guardar Datos";

                BT_AgrArt.Click += new System.EventHandler(BT_ModArt_Click);

                this.idArt = idArt;

                if (idArt != 0)
                {
                    Obtener obtener = new Obtener();
                    List<ObjArticulo> list = obtener.ObtenerLA();
                    ObjArticulo articulo = new ObjArticulo();

                    try
                    {
                        for (int i = 1; i < list.Count; i++)
                        {
                            if (list[i].codigo == idArt)
                                articulo = new ObjArticulo(list[i]);
                        }

                        TB_Nombre.Text = articulo.nombre;
                        TB_Descripcion.Text = articulo.detalles;
                        NUD_Cantidad.Value = articulo.cantidad;
                        NUD_Precio.Value = articulo.precio;
                    }
                    catch
                    {
                        MessageBox.Show("No se encontró el articulo");

                        E = false;
                    }
                }
            }
        }

        private void BT_AgrArt_Click(object sender, EventArgs e)
        {
            Verificacion(mod);
        }

        private void BT_ModArt_Click(object sender, EventArgs e)
        {
            Verificacion(mod);
        }

        public void Verificacion(string instruccion)
        {
            bool DL = true;
            bool H = true;

            if (E)
            {
                // Verificaciones de campos llenos //
                if (TB_Nombre.Text == "Nombre" || TB_Nombre.Text == "" || NUD_Precio.Value == Decimal.Parse("0.00") || TB_Nombre.Text == "*Campo Obligatorio*")
                {
                    if (TB_Nombre.Text == "Nombre" || TB_Nombre.Text == "" || TB_Nombre.Text == "*Campo Obligatorio*")
                    {
                        TB_Nombre.ForeColor = Color.Red;
                        TB_Nombre.Text = "*Campo Obligatorio*";
                    }
                    if(NUD_Precio.Value == Decimal.Parse("0.00"))
                    {
                        NUD_Precio.ForeColor = Color.Red;
                    }

                    MessageBox.Show("Datos Incompletos");
                }
                else
                {
                    ObjArticulo articulo = new ObjArticulo(TB_Nombre.Text, Convert.ToInt32(NUD_Cantidad.Value), NUD_Precio.Value, TB_Descripcion.Text, imagen); // Creación del usuario //

                    QueryArticulo agregar = new QueryArticulo(instruccion, articulo); // Query para agregar nuevo usuario //
                }

                this.Close();
            }
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

        private void PB_Imagen_Click(object sender, EventArgs e)
        {
            try
            {
                OFD_ArtNuevo.Title = "Elige una imagen";
                OFD_ArtNuevo.InitialDirectory = "c:\\";
                OFD_ArtNuevo.Filter = "Archivos jpg (*.jpg)|*.jpg| Archivos png (*.png)|*.png";
                OFD_ArtNuevo.FilterIndex = 1;
                OFD_ArtNuevo.RestoreDirectory = true;
                OFD_ArtNuevo.ShowDialog();

                if (File.Exists(OFD_ArtNuevo.FileName))
                {
                    LB_Imagen.Visible = false;
                    PB_Imagen.ImageLocation = OFD_ArtNuevo.FileName;
                    imagen = OFD_ArtNuevo.FileName;
                    // Activar boton de quitar imagen
                }
                else
                {
                    MessageBox.Show("No se seleccionó ninguna imagen", "Sin selección",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir");
            }
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void NUD_Precio_ValueChanged(object sender, EventArgs e)
        {
            NUD_Precio.ForeColor = Color.Black;
        }

        private void TB_Nombre_Click(object sender, EventArgs e)
        {
            TB_Nombre.ForeColor = Color.Black;
            TB_Nombre.Text = "";
        }

        private void AgregarArticulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
