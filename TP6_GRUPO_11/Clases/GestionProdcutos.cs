using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_11.Clases
{
    public class GestionProdcutos
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