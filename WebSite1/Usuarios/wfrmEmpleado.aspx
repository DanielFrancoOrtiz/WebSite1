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
            <asp:Label ID="Label11"  Width="20%" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6"  Width="20%" runat="server"></asp:Label>
            <asp:Label ID="Label1" Width="15%" runat="server" Text="ID:"></asp:Label>
            <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblNonAnt"  Width="20%" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label2" Width="15%" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEdadAnt"  Width="20%" runat="server"></asp:Label>
            <asp:Label ID="Label3" Width="15%" runat="server" Text="Edad:"></asp:Label>
            <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDirAnt"  Width="20%" runat="server"></asp:Label>
            <asp:Label ID="Label4" Width="15%" runat="server" Text="Direccion:"></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblTelAnt"  Width="20%" runat="server"></asp:Label>
            <asp:Label ID="Label5" Width="15%" runat="server" Text="Telefono:"></asp:Label>
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            <br />
            <br />
            
            <asp:Label ID="Label12"  Width="20%" runat="server"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Agregar" Width="188px" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancelar" Width="68px" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
