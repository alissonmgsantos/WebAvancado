<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4>Operações matemática (Template Method)</h4>
            <table style="border: solid 1px;">
                <tr>
                    <td>
                        <asp:Label ID="lblValor1" runat="server" Text="Valor 1"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtValor1" runat="server" placeholder="Digite um número"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblValor2" runat="server" Text="Valor 2"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtValor2" runat="server" placeholder="Digite outro número"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblOperacao" runat="server" Text="Operação"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtOperacao" runat="server" placeholder="Informe a operação"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMensagem" runat="server" Text="Resultado:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
             
                        <asp:Label ID="Label1" runat="server" Text="Resultado:"></asp:Label>
                   
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                   
        </div>
    </form>
</body>
</html>
