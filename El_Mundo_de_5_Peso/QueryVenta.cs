using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace El_Mundo_de_5_Peso
{
    class QueryVenta
    {
        public QueryVenta(string comando, ObjVenta venta)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    switch (comando)
                    {
                        case "agregar":
                            {
                                SqlCommand cmd = new SqlCommand("INSERT INTO Venta(usuario, articulos, cantidad, total, fecha, hora, estado)" +
                                    "VALUES ('" + venta.usuario + "', '" + venta.articulos + "', '" + venta.cantidad + "'," +
                                    " '" + venta.total + "', '" + venta.fecha + "', '" + venta.hora + "', '" + venta.estado + "')", conexion);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Venta Realizada");
                            }
                            break;

                        case "modificar":
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE Venta SET usuario = '" + venta.usuario + "', articulos = '" + venta.articulos + "'," +
                                    " cantidad = '" + venta.cantidad + "', total = '" + venta.total + "', fecha = '" + venta.fecha + "'," +
                                    " hora = '" + venta.hora + ", estado = '" + venta.estado + "' WHERE id = " + venta.numVenta + "", conexion);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Venta modificada");
                            }
                            break;
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
