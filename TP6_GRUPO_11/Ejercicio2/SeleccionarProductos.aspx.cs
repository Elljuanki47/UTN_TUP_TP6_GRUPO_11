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
    public partial class SeleccionarProductos : System.Web.UI.Page
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
            GestionProductos gestion = new GestionProductos();
            gvProductos.DataSource = gestion.TodosLosDatos();
            gvProductos.DataBind();
        }
        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow filaSeleccionada = gvProductos.SelectedRow;

            string idProducto = filaSeleccionada.Cells[0].Text;
            string nombreProducto = HttpUtility.HtmlDecode(filaSeleccionada.Cells[1].Text);

            DataTable dtSeleccionados = Session["ElementosSeleccionados"] as DataTable;

            if (dtSeleccionados == null)
            {
                dtSeleccionados = new DataTable();
                dtSeleccionados.Columns.Add("IdProducto");
                dtSeleccionados.Columns.Add("NombreProducto");
                dtSeleccionados.Columns.Add("IdProveedor");
                dtSeleccionados.Columns.Add("PrecioUnidad");
            }

            foreach(DataRow producto in dtSeleccionados.Rows)
            {
                if (producto["IdProducto"].ToString() == idProducto)
                {
                    lblProductoSeleccionado.ForeColor = System.Drawing.Color.Red;
                    lblProductoSeleccionado.Text = "El producto ya estaba seleccionado: " + nombreProducto;
                    return;
                }
            }

            DataRow nuevaFila = dtSeleccionados.NewRow();

            nuevaFila["IdProducto"] = idProducto;
            nuevaFila["NombreProducto"] = nombreProducto;
            nuevaFila["IdProveedor"] = HttpUtility.HtmlDecode(filaSeleccionada.Cells[2].Text);
            nuevaFila["PrecioUnidad"] = HttpUtility.HtmlDecode(filaSeleccionada.Cells[3].Text);

            dtSeleccionados.Rows.Add(nuevaFila);

            Session["ElementosSeleccionados"] = dtSeleccionados;

            lblProductoSeleccionado.ForeColor = System.Drawing.Color.Green;
            lblProductoSeleccionado.Text = "Producto agregado: " + nombreProducto;
        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }

    }
}