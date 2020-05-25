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
    class Conexion
    {
        string cadena = "Data Source=.;Initial Catalog=M5PDB;Integrated Security=True";
        public SqlConnection conexion = new SqlConnection();

        public Conexion()
        {
            conexion.ConnectionString = cadena;
        }

        public void Open()
        {
            try
            {
                conexion.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al abri la BD." + ex.Message);
            }
        }

        public void Close()
        {
            conexion.Close();
        }
    }
}
