using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6_GRUPO_11.Clases;

namespace TP6_GRUPO_11.Ejercicio1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGridView();
            }
        }

        private void CargarGridView()
        {
            GestionProductos gestionProductos = new GestionProductos();
            gvProductos.DataSource = gestionProductos.TodosLosDatos();
            gvProductos.DataBind();
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }

        protected void gvProductos_BorrarFila(object sender, GridViewDeleteEventArgs e)
        {
            int idProducto = Convert.ToInt32(gvProductos.DataKeys[e.RowIndex].Value);

            GestionProductos gestion = new GestionProductos();

            gestion.EliminarProducto(idProducto);

            gvProductos.PageIndex = 0;
            CargarGridView();

            lblMensaje.ForeColor = System.Drawing.Color.Red;
            lblMensaje.Text = "El producto con ID " + idProducto + " fue eliminado correctamente.";
        }

        protected void gvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProductos.EditIndex = e.NewEditIndex;
            CargarGridView();
        }

        protected void gvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProductos.EditIndex = -1;
            CargarGridView();
        }

        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow fila = gvProductos.Rows[e.RowIndex];

            string nombre = ((TextBox)fila.FindControl(
                "txt_eit_NombreProducto")).Text.Trim();

            string cantidad = ((TextBox)fila.FindControl(
                "txt_eit_CantidadPorUnidad")).Text.Trim();

            string textoPrecio = ((TextBox)fila.FindControl(
                "txt_eit_PrecioUnidad")).Text.Trim();

            lblMensaje.Text = "";

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(cantidad))
            {
                lblMensaje.Text = "Completá el nombre y la cantidad por unidad.";
                e.Cancel = true;
                return;
            }

            decimal precio;

            bool precioValido = decimal.TryParse(
                textoPrecio.Replace(',', '.'),
                System.Globalization.NumberStyles.AllowDecimalPoint,
                System.Globalization.CultureInfo.InvariantCulture,
                out precio);

            if (!precioValido || precio < 0)
            {
                lblMensaje.Text = "Ingresá un precio válido, mayor o igual a cero.";
                e.Cancel = true;
                return;
            }

            GestionProductos gestion = new GestionProductos();

            int idProducto = Convert.ToInt32(gvProductos.DataKeys[e.RowIndex].Value);

            gestion.EditarProducto(
                idProducto,
                nombre,
                cantidad,
                precio
            );

            gvProductos.EditIndex = -1;
            CargarGridView();

            lblMensaje.ForeColor = System.Drawing.Color.Green;
            lblMensaje.Text = "El producto con ID " + idProducto + " se actualizó correctamente.";
        }
    }
    
}