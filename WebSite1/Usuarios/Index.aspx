<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Usuarios_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 254px">
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" />
            <asp:Button ID="btnEditar" runat="server" Text="Editar" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
            <asp:Button ID="btnSalir" runat="server" Text="Salir" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
