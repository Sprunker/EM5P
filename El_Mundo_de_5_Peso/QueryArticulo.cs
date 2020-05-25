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
    class QueryArticulo
    {
        public QueryArticulo(string comando, ObjArticulo articulo)
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
                                SqlCommand cmd = new SqlCommand("INSERT INTO Articulo(nombre, cantidad, precio, detalles, imagen)" +
                                    "VALUES ('" + articulo.nombre + "', '" + articulo.cantidad + "', '" + articulo.precio + "', '" + articulo.detalles + "'," +
                                    "'" + articulo.imagen + "')", conexion);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Se ha agregado el articulo " + articulo.nombre);
                            }
                            break;

                        case "modificar":
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE Articulo SET nombre = '" + articulo.nombre + "', cantidad = '" + articulo.cantidad + "'," +
                                    " precio = '" + articulo.precio + "', detalles = '" + articulo.detalles + "', imagen = '" + articulo.imagen, conexion);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Se ha modificado el articulo " + articulo.nombre);
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
