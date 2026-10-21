<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarProductos.aspx.cs" Inherits="TP6_GRUPO_11.Ejercicio2.SeleccionarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Ejercicio 2 - Seleccionar Productos</title>
</head>

<body>

    <form id="form1" runat="server">

        <div>

            <h3 style="text-decoration: underline;">SELECCIONAR PRODUCTOS</h3>

            <asp:GridView ID="gvProductos" runat="server"
                AutoGenerateColumns="False"
                AllowPaging="True"
                PageSize="14"
                OnSelectedIndexChanged="gvProductos_SelectedIndexChanged"
                OnPageIndexChanging="gvProductos_PageIndexChanging"
                CellPadding="8">

            <HeaderStyle HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" />

                <Columns>
                    <asp:BoundField DataField="IdProducto" HeaderText="Id Producto" ReadOnly="True" />

                    <asp:BoundField DataField="NombreProducto" HeaderText="Nombre Producto" />

                    <asp:BoundField DataField="IdProveedor" HeaderText="Id Proveedor" />

                    <asp:BoundField DataField="PrecioUnidad" HeaderText="Precio Unitario" />

                    <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" SelectText="Seleccionar" />
                </Columns>

            </asp:GridView>
            
            <br />

            <asp:Label ID="lblProductoSeleccionado" runat="server">
            </asp:Label>

            <br /><br />

            <asp:HyperLink ID="hlVolver" runat="server"
                NavigateUrl="~/Ejercicio2/Inicio.aspx"
                Text="Volver al inicio">
            </asp:HyperLink>

        </div>
    </form>
</body>
</html>
