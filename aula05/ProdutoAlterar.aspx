<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProdutoAlterar.aspx.cs" Inherits="ProdutoAlterar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" Runat="Server">
    <div style="text-align:center;">
        <table>
            <tr>
                <td>
                     <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
    <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                     <asp:Label ID="lblFornecedor" runat="server" Text="Fornecedor"></asp:Label>
    <asp:TextBox ID="txtFornecedor" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="lblPreco" runat="server" Text="Preço"></asp:Label>
    <asp:TextBox ID="txtPreco" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                     <asp:Label ID="lblEstoque" runat="server" Text="Estoque"></asp:Label>
    <asp:TextBox ID="txtEstoque" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                      <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" />
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click"/>
                </td>
            </tr>
        </table>
      
   
    
   
          
        </div>
        <asp:Label ID="lblid" runat="server" Text=""></asp:Label>
</asp:Content>

