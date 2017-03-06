<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora IMC</title>
</head>
<body>
    <form id="CalculoIMC" runat="server">
    <div>
    <table style="border:solid 1px;">
        <tr>
            <td>
                <h2>Calculadora IMC</h2>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="lblPeso" runat="server" Text="Peso"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAltura" runat="server" Text="Altura"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtAltura" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td style="text-align:center">
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
               </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
