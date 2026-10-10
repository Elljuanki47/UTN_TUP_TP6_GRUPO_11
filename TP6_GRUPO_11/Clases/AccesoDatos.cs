using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP6_GRUPO_11.Clases
{
    public class AccesoDatos
    {
        private string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion); 
        }

        public SqlDataAdapter ObtenerAdaptador(string consultaSQL)
        {
            SqlConnection conexion = ObtenerConexion();

            SqlDataAdapter adaptador = new SqlDataAdapter(consultaSQL, conexion);

            return adaptador;
        }
    }
}