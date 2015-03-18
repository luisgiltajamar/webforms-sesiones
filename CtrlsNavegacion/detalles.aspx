<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detalles.aspx.cs" Inherits="CtrlsNavegacion.detalles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label runat="server" ID="Texto"></asp:Label>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="tercera.aspx">
        A la tercera
    </asp:HyperLink>

    </div>
    </form>
</body>
</html>
