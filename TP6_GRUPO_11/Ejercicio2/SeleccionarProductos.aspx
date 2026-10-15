<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarProductos.aspx.cs" Inherits="TP6_GRUPO_11.Ejercicio2.SeleccionarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejercicio 2 - Seleccionar Productos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Seleccionar productos</h2>

            <asp:GridView ID="gvProductos" runat="server"
                AutoGenerateColumns="False"
                AllowPaging="True"
                PageSize="14">

                <Columns>
                    <asp:BoundField
                        DataField="IdProducto"
                        HeaderText="Id Producto"
                        ReadOnly="True" />

                    <asp:BoundField
                        DataField="NombreProducto"
                        HeaderText="Nombre Producto" />

                    <asp:BoundField
                        DataField="IdProveedor"
                        HeaderText="Id Proveedor" />

                    <asp:BoundField
                        DataField="PrecioUnidad"
                        HeaderText="Precio Unitario" />

                    <asp:CommandField
                        ShowSelectButton="True"
                        SelectText="Seleccionar" />
                </Columns>
            </asp:GridView>
            
            <br />

            <asp:Label ID="lblProductoSeleccionado"
                runat="server">
            </asp:Label>

            <br /><br />

            <asp:HyperLink ID="hlVolver"
                runat="server"
                NavigateUrl="~/Ejercicio2/Inicio.aspx"
                Text="Volver al inicio">
            </asp:HyperLink>

        </div>
    </form>
</body>
</html>
