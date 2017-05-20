<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProdutoListagem.aspx.cs" Inherits="ProdutoListagem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" Runat="Server">
    
        <div style="text-align:center;">
        <asp:Label ID="lblDescricao" runat="server" Text="Descrição"></asp:Label>
    <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
    <asp:Label ID="lblFornecedor" runat="server" Text="Fornecedor"></asp:Label>
    <asp:TextBox ID="txtFornecedor" runat="server"></asp:TextBox>
    <asp:Label ID="lblPreco" runat="server" Text="Preço"></asp:Label>
    <asp:TextBox ID="txtPreco" runat="server"></asp:TextBox>
    <asp:Label ID="lblEstoque" runat="server" Text="Estoque"></asp:Label>
    <asp:TextBox ID="txtEstoque" runat="server"></asp:TextBox>
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
            <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click"/>
           <hr/>
    <asp:GridView ID="grdProduto" runat="server" AutoGenerateColumns="false" AutoGenerateSelectButton="true" PageSize="10" EmptyDataText="Sem registro" DataKeyNames="idProduto" Width="100%" OnPageIndexChanging="grdProduto_PageIndexChanging" OnSelectedIndexChanged="grdProduto_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="idProduto" HeaderText="Código" InsertVisible="false"/>
            <asp:BoundField DataField="dsDescricao" HeaderText="Descrição" />
            <asp:BoundField DataField="dsFornecedor" HeaderText="Fornecedor" />
            <asp:BoundField DataField="vlValor" HeaderText="Valor" />
            <asp:BoundField DataField="qtEstoque" HeaderText="Estoque" />
        </Columns>
        <SelectedRowStyle BackColor="Yellow" ForeColor="DarkBlue" Font-Bold="true" />
    </asp:GridView>
            <hr/>
            <asp:Button ID="btnVisualizar" runat="server" Text="Visualizar" Width="100px" />
            <asp:Button ID="btnAlterar" runat="server" Text="Alterar" Width="100px" OnClick="btnAlterar_Click" />
            <asp:Button ID="btnDeletar" runat="server" Text="Deletar" Width="100px" />
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" Width="100px" />
            <asp:Label ID="lblid" runat="server" Text=""></asp:Label>
     </div>
</asp:Content>

