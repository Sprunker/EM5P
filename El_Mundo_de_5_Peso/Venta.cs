using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Mundo_de_5_Peso
{
    public partial class Venta : Form
    {
        string mod;
        bool E = true;
        int idVenta;
        Obtener obtener = new Obtener();
        List<ObjArticulo> list;
        List<ObjArticulo> list2 = new List<ObjArticulo>();
        decimal total;
        decimal totalVenta;
        bool AC;

        public Venta(string mod, int idVenta)
        {
            InitializeComponent();

            list = obtener.ObtenerLA();
            this.mod = mod;
            total = 0;

            if (mod == "agregar")
            {
                // Agregar propiedades //
                LB_Titulo.Location = new Point(347, 16);
                LB_Titulo.Text = "VENTA";

                BT_ReaVenta.Text = "Realizar venta";
                BT_ReaVenta.Click += new System.EventHandler(BT_AgrVenta_Click);
            }
            else if (mod == "modificar")
            {
                // Agregar propiedades //
                LB_Titulo.Location = new Point(247, 16);
                LB_Titulo.Text = "MODIFICAR VENTA";

                BT_ReaVenta.Text = "Guardar Datos";
                BT_ReaVenta.Click += new System.EventHandler(BT_ModVenta_Click);

                this.idVenta = idVenta;

                if (idVenta != 0)
                {
                    Obtener obtener = new Obtener();
                    List<ObjVenta> list = obtener.ObtenerLV();
                    ObjVenta venta = new ObjVenta();

                    try
                    {
                        for (int i = 1; i < list.Count; i++)
                        {
                            if (list[i].numVenta == idVenta)
                                venta = new ObjVenta(list[i]);
                        }

                        // Agregar los daos de la venta y cambiar el valor de total
                    }
                    catch
                    {
                        MessageBox.Show("No se encontró la venta");

                        E = false;
                    }
                }
            }
        }

        private void BT_AgrVenta_Click(object sender, EventArgs e)
        {
            Verificacion(mod);
        }

        private void BT_ModVenta_Click(object sender, EventArgs e)
        {
            Verificacion(mod);
        }

        public void Verificacion(string instruccion)
        {

            // NumVenta, Usuario, Articulos, Cantidad, Total, Fecha, Hora, Estado

            ObjUsuario usuario = new ObjUsuario();
            Obtener obtener = new Obtener();
            List<ObjUsuario> list3 = obtener.ObtenerLU();
            usuario = list3[2];
            string articulos = "";
            int cont = 0;
            foreach(ObjArticulo articulo in list2)
            {
                articulos += "New Line: " + articulo.codigo;
                cont++;
            }

            ObjVenta venta = new ObjVenta(usuario.nombre, articulos, cont, totalVenta, Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")), 
                Convert.ToDateTime(DateTime.Now.ToString("hh:mm")), "Realizada");

            QueryVenta agregar = new QueryVenta(instruccion, venta); // Query para agregar nuevo usuario //

            this.Close();
        }

        private void Venta_Load(object sender, EventArgs e)
        {

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

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            ObjArticulo articulo1 = new ObjArticulo();
            total = 0;
            AC = true;
            E = false;

            if(TB_CodProd.Text != "Código de Artículo" || TB_NomPro.Text != "Nomdre de Artículo" || TB_CodProd.Text != "" || TB_NomPro.Text != "")
            {
                foreach (ObjArticulo articulo in list)
                {
                    if (TB_NomPro.Text == articulo.nombre || Convert.ToInt32(TB_CodProd.Text) == articulo.codigo)
                    {
                        articulo1 = articulo;
                        E = true;
                        break;
                    }
                }

                // Codigo Art, Nombre, Cantidad, Precio U, Total

                if (E)
                {
                    if (TB_Cantidad.Text != "Cantidad" || TB_Cantidad.Text != "")
                    {
                        if (Convert.ToInt32(TB_Cantidad.Text) > 0)
                        {
                            try
                            {
                                totalVenta += articulo1.precio * Convert.ToInt32(TB_Cantidad.Text);
                                total += articulo1.precio * Convert.ToInt32(TB_Cantidad.Text);
                            }
                            catch
                            {
                                MessageBox.Show("El campo de cantidad es incorrecto");
                                AC = false;
                            }

                            if (AC)
                            {
                                int rowEscribir = DGV_Venta.Rows.Count - 1;

                                DGV_Venta.Rows.Add(1);

                                DGV_Venta.Rows[rowEscribir].Cells[0].Value = articulo1.codigo;
                                DGV_Venta.Rows[rowEscribir].Cells[1].Value = articulo1.nombre;
                                DGV_Venta.Rows[rowEscribir].Cells[2].Value = TB_Cantidad.Text;
                                DGV_Venta.Rows[rowEscribir].Cells[3].Value = articulo1.precio;
                                DGV_Venta.Rows[rowEscribir].Cells[4].Value = total;

                                list2.Add(articulo1);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingresa una cantidad mayor a 0");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el artículo");
                }
            }
        }

        private void Venta_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
