<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarProductos.aspx.cs" Inherits="TP6_GRUPO_11.Ejercicio2.MostrarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">

        <div>

            <h3 style="text-decoration: underline;">PRODUCTOS SELECCIONADOS</h3>

            <asp:Label ID="lblCantidadProductos" runat="server" Font-Bold="True">
            </asp:Label>
            <br /><br />

            <asp:GridView ID="gvSeleccion" runat="server"
                AutoGenerateColumns="False"
                DataKeyNames="IdProducto"
                OnRowDeleting="QuitarProducto"
                CellPadding="8">
            <HeaderStyle HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" />

                <Columns>

                    <asp:BoundField DataField="IdProducto" HeaderText="Id Producto" />
                    <asp:BoundField DataField="NombreProducto" HeaderText="Nombre Producto" />
                    <asp:BoundField DataField="IdProveedor" HeaderText="Id Proveedor" />
                    <asp:BoundField DataField="PrecioUnidad" HeaderText="Precio Unitario" />
                    <asp:CommandField HeaderText="Quitar" ShowDeleteButton="True" DeleteText="Quitar" />

                </Columns>

            </asp:GridView>

        </div>

        <asp:Label ID="lblProductosSeleccionados" runat="server"></asp:Label>

        <br /><br />

        <asp:HyperLink ID="hlVolver" runat="server"
            NavigateUrl="~/Ejercicio2/Inicio.aspx"
            Text="Volver al inicio">
        </asp:HyperLink>

    </form>

</body>
</html>
