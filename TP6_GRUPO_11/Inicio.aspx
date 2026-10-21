<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP6_GRUPO_11.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TP6 - Grupo 11</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Trabajo Práctico N° 6</h2>
            <h3>Programación 3 - Grupo 11</h3>

            <p>Seleccione el ejercicio que desea realizar:</p>

            <asp:HyperLink ID="hlEjercicio1" runat="server"
                NavigateUrl="~/Ejercicio1/Ejercicio1.aspx"
                Text="Ejercicio 1 - Administración de productos">
            </asp:HyperLink>

            <br /><br />

            <asp:HyperLink ID="hlEjercicio2" runat="server"
                NavigateUrl="~/Ejercicio2/Inicio.aspx"
                Text="Ejercicio 2 - Selección de productos">
            </asp:HyperLink>
        </div>
    </form>
</body>
</html>