<%@ Page Language="C#" AutoEventWireup="true" CodeFile="resultado.aspx.cs" Inherits="resultado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora IMC - Resultado</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblResultado" runat="server" Text="Resultado"></asp:Label><br/>
        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
    </div>
    </form>
</body>
</html>
