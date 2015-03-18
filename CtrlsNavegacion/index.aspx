<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CtrlsNavegacion.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/detalles.aspx?texto=hola&amp;numero=7">HyperLink</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
