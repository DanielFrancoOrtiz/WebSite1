<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wfrmEmpleado.aspx.cs" Inherits="Usuarios_wfrmEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" Width="15%" runat="server" Text="ID:"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text=" "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" Width="15%" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" Width="15%" runat="server" Text="Edad:"></asp:Label>
            <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" Width="15%" runat="server" Text="Direccion:"></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" Width="15%" runat="server" Text="Telefono:"></asp:Label>
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Agregar" Width="254px" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
