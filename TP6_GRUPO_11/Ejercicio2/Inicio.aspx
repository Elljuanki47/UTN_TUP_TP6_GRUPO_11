<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP6_GRUPO_11.Ejercicio2.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejercicio 2 - Inicio</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 227px;
        }
        .auto-style4 {
            width: 162px;
        }
        .auto-style5 {
            width: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Ejercicio 2 - Seleccion de productos</h2>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:HyperLink ID="hlSeleccionarProductos" runat="server" NavigateUrl="~/Ejercicio2/SeleccionarProductos.aspx">Seleccionar Productos</asp:HyperLink>
                </td>
                <td class="auto-style3">
                    <asp:LinkButton ID="lbEliminarSeleccionados" runat="server">Eliminar productos seleccionados</asp:LinkButton>
                </td>
                <td class="auto-style4">
                    <asp:HyperLink ID="hlMostrarProductos" runat="server" NavigateUrl="~/Ejercicio2/MostrarProductos.aspx">Mostrar productos </asp:HyperLink>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
