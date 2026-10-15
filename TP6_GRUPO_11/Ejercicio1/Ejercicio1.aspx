<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP6_GRUPO_11.Ejercicio1.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Productos<br />
            <asp:GridView ID="gvProductos" runat="server"
                AutoGenerateColuns="False"
                AllowPaging="True"
                PageSize="10"
                OnPageIndexChanging="gvProductos_PageIndexChanging">

                <Columns>
                    <asp:BoundField DataField="IdProducto"
                        HeaderText="Id Producto" ReadOnly="True" />

                    <asp:BoundField DataField="NombreProducto"
                        HeaderText="Nombre Producto" />

                    <asp:BoundField DataField="CantidadPorUnidad"
                        HeaderText="Cantidad Por Unidad" />

                    <asp:BoundField DataField="PrecioUnidad"
                        HeaderText="Precio Unidad" />
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
