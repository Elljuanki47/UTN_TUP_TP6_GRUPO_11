using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP6_GRUPO_11.Clases
{
    public class GestionProductos
    {
        public DataTable TodosLosDatos()
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            string consultaSQL = "SELECT * FROM Productos";
            DataTable tablaProductos = new DataTable();
            
            SqlDataAdapter adaptador = accesoDatos.ObtenerAdaptador(consultaSQL);
            adaptador.Fill(tablaProductos);
            return tablaProductos;
        }
    }
}