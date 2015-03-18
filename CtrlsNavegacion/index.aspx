<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CtrlsNavegacion.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Usuarios conectados:
        <asp:Label ID="lblNusu" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Cuantos años tienes:"/>
        <asp:TextBox ID="txtAños" runat="server"/>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <asp:Label runat="server" ID="lblAños"></asp:Label>
        <br />
        <br />
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/detalles.aspx?texto=hola&amp;numero=7">HyperLink</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
