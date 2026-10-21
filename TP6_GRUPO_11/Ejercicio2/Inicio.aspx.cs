using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_11.Ejercicio2
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbEliminarSeleccionados_Click(object sender, EventArgs e)
        {
            System.Data.DataTable seleccionados =
                Session["ElementosSeleccionados"] as System.Data.DataTable;

            if (seleccionados == null || seleccionados.Rows.Count == 0)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "No hay productos seleccionados para eliminar.";
                return;
            }

            Session.Remove("ElementosSeleccionados");

            lblMensaje.ForeColor = System.Drawing.Color.Green;
            lblMensaje.Text = "Se eliminaron los productos de la selección.";
        }

    }
}