<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:DropDownList ID="ddlMes" runat="server" OnSelectedIndexChanged="ddlMes_SelectedIndexChanged">
                <asp:ListItem Value="" Selected="true">Selecione um mês</asp:ListItem>
                <asp:ListItem Value="1">Janeiro</asp:ListItem>
                <asp:ListItem Value="2">Fevereiro</asp:ListItem>
                <asp:ListItem Value="3">Março</asp:ListItem>
                <asp:ListItem Value="4">Abril</asp:ListItem>
                <asp:ListItem Value="5">Maio</asp:ListItem>
                <asp:ListItem Value="6">Junho</asp:ListItem>
                <asp:ListItem Value="7">Julho</asp:ListItem>
                <asp:ListItem Value="8">Agosto</asp:ListItem>
                <asp:ListItem Value="9">Setembro</asp:ListItem>
                <asp:ListItem Value="10">Outubro</asp:ListItem>
                <asp:ListItem Value="11">Novembro</asp:ListItem>
                <asp:ListItem Value="12">Dezembro</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <br />
            <table border="0">
                <tr>
                    <td>
                        <asp:ListBox ID="lst1" runat="server" Height="150px" Width="150px">
                            <asp:ListItem Value="1">Domingo</asp:ListItem>
                            <asp:ListItem Value="2">Segunda</asp:ListItem>
                            <asp:ListItem Value="3">Terça</asp:ListItem>
                            <asp:ListItem Value="4">Quarta</asp:ListItem>
                            <asp:ListItem Value="5">Quinta</asp:ListItem>
                            <asp:ListItem Value="6">Sexta</asp:ListItem>
                            <asp:ListItem Value="7">Sábado</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td>
                     <asp:Button ID="btnIncluir" runat="server" Text=">" Width="30px" Height="30px" OnClick="btnIncluir_Click"/><br />
                    <asp:Button ID="btnTodos" runat="server" Text=">>" Width="30px" Height="30px" OnClick="btnTodos_Click"/><br />
                    <asp:Button ID="btnRemover" runat="server" Text="<" Width="30px" Height="30px" OnClick="btnRemover_Click"/><br/>
                        <asp:Button ID="btnRemoverTodos" runat="server" Text="<<" Width="30px" Height="30px" OnClick="btnRemoverTodos_Click"/>
                    </td>
                    <td>
                        <asp:ListBox ID="lst2" runat="server"  Height="150px" Width="150px">

                        </asp:ListBox>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
