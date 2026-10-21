using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_11.Clases;

namespace TP6_GRUPO_11.Ejercicio2
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ElementosSeleccionados"] != null)
                {
                    DataTable tabla = Session["ElementosSeleccionados"] as DataTable;

                    gvSeleccion.DataSource = tabla;
                    gvSeleccion.DataBind();

                    lblCantidadProductos.Text = "Cantidad de productos seleccionados: " + tabla.Rows.Count;
                }
                else
                {
                    lblProductosSeleccionados.Text = "No hay productos seleccionados.";
                }
            }
        }

        protected void QuitarProducto(object sender, GridViewDeleteEventArgs e)
        {
            DataTable tabla = Session["ElementosSeleccionados"] as DataTable;

            string idProducto = tabla.Rows[e.RowIndex]["IdProducto"].ToString();

            tabla.Rows.RemoveAt(e.RowIndex);

            Session["ElementosSeleccionados"] = tabla;

            gvSeleccion.DataSource = tabla;
            gvSeleccion.DataBind();

            lblProductosSeleccionados.ForeColor = System.Drawing.Color.Red;

            lblProductosSeleccionados.Text = "<br />" + "El producto con ID " + idProducto + " fue quitado de la selección.";

            lblCantidadProductos.Text = "Cantidad de productos seleccionados: " + tabla.Rows.Count;

            if (tabla.Rows.Count == 0)
            {
                lblProductosSeleccionados.Text = "No hay productos seleccionados";
            }
        }
    }
}