using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml.Schema;

namespace El_Mundo_de_5_Peso
{
    class Obtener
    {
        public List<ObjUsuario> ObtenerLU()
        {
            Conexion cn = new Conexion();
            cn.Open();

            string query = "SELECT * FROM Usuario"; 
            SqlCommand comando = new SqlCommand(query, cn.conexion);

            var list = new List<ObjUsuario>();
            using (var reader = comando.ExecuteReader())
            {
                while(reader.Read())
                {
                    list.Add(new ObjUsuario
                    {
                        id = reader.GetInt32(0),
                        nombre = reader.GetString(1),
                        usuario = reader.GetString(2),
                        pass = reader.GetString(3),
                        telefono = reader.GetString(4),
                        diasLab = reader.GetBoolean(5),
                        horario = reader.GetBoolean(6)
                    });
                }
            }

            return list;
        }

        public List<ObjArticulo> ObtenerLA()
        {
            Conexion cn = new Conexion();
            cn.Open();

            string query = "SELECT * FROM Articulo";
            SqlCommand comando = new SqlCommand(query, cn.conexion);
            //SqlDataAdapter data = new SqlDataAdapter(comando);
            //DataTable table = new DataTable();
            //data.Fill(table); // Llenar tabla

            var list = new List<ObjArticulo>();
            using (var reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new ObjArticulo
                    {
                        codigo = reader.GetInt32(0),
                        nombre = reader.GetString(1),
                        cantidad = reader.GetInt32(2),
                        precio = reader.GetDecimal(3),
                        detalles = reader.GetString(4),
                        imagen = reader.GetString(5)
                    });
                }
            }

            return list;
        }

        public List<ObjVenta> ObtenerLV()
        {
            Conexion cn = new Conexion();
            cn.Open();

            string query = "SELECT * FROM Usuario";
            SqlCommand comando = new SqlCommand(query, cn.conexion);
            //SqlDataAdapter data = new SqlDataAdapter(comando);
            //DataTable table = new DataTable();
            //data.Fill(table); // Llenar tabla

            var list = new List<ObjVenta>();
            using (var reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new ObjVenta
                    {
                        numVenta = reader.GetInt32(0),
                        usuario = reader.GetString(1),
                        articulos = reader.GetString(2),
                        cantidad = reader.GetInt32(3),
                        total = reader.GetDecimal(4),
                        fecha = reader.GetDateTime(5),
                        hora = reader.GetDateTime(6),
                        estado = reader.GetString(7)
                    });
                }
            }

            return list;
        }
    }
}
