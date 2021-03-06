﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace El_Mundo_de_5_Peso
{
    public class QueryUsuario
    {
        public QueryUsuario(string comando, ObjUsuario usuario)
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
                                SqlCommand cmd = new SqlCommand("INSERT INTO Usuario(nombre, usuario, pass, telefono, diasLab, horario)" +
                                    "VALUES ('"+usuario.nombre+"', '"+usuario.usuario+"', '"+usuario.pass+"', '"+usuario.telefono+"'," +
                                    "'"+usuario.diasLab+"', '"+usuario.horario+"')", conexion);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Se ha agregado el usuario " + usuario.usuario);
                            }
                            break;

                        case "modificar":
                            {
                                SqlCommand cmd = new SqlCommand("UPDATE Usuario SET nombre = '"+usuario.nombre+"', usuario = '"+usuario.usuario+"'," +
                                    " pass = '"+usuario.pass+"', telefono = '"+usuario.telefono+"', diasLab = '"+usuario.diasLab+"'," +
                                    " horario = '"+usuario.horario+ "' WHERE id = " + usuario.id + "", conexion);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Se ha modificado el usuario " + usuario.usuario);
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
