<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h5>Consulta - Facade</h5>
            <table style="border:solid 1px;">
                <tr>
                    <td>
                        <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCpf" runat="server" Text="CPF"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmprestimo" runat="server" Text="Empréstimo"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmprestimo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnVerificar" runat="server" Text="Verificar" OnClick="btnVerificar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
