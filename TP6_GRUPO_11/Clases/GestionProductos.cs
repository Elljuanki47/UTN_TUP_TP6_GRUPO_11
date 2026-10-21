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

        public void EliminarProducto(int idProducto)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            SqlConnection conexion = accesoDatos.ObtenerConexion();

            SqlCommand comando = new SqlCommand(
                "DELETE FROM Productos WHERE IdProducto = @IdProducto",
                conexion);

            comando.Parameters.AddWithValue("@IdProducto", idProducto);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void EditarProducto(int idProducto, string nombreProducto, string cantidadPorUnidad, decimal precioUnidad)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            SqlConnection conexion = accesoDatos.ObtenerConexion();

            SqlCommand comando = new SqlCommand(
                "UPDATE Productos " +
                "SET NombreProducto = @NombreProducto, " +
                "CantidadPorUnidad = @CantidadPorUnidad, " +
                "PrecioUnidad = @PrecioUnidad " +
                "WHERE IdProducto = @IdProducto",
                conexion);

            comando.Parameters.AddWithValue("@NombreProducto", nombreProducto);
            comando.Parameters.AddWithValue("@CantidadPorUnidad", cantidadPorUnidad);
            comando.Parameters.AddWithValue("@PrecioUnidad", precioUnidad);
            comando.Parameters.AddWithValue("@IdProducto", idProducto);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

    }
}