<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CtrlsNavegacion.Default" %>

<%@ Register Src="~/Fecha.ascx" TagPrefix="uc1" TagName="Fecha" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Fecha runat="server" id="Fecha"
            OnFechaActualizada="ManejarFechaActualizada"
              FechaActual="15-10-2013" Fondo="0"/>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
