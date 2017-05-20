using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProdutoListagem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFiltrar_Click(object sender, EventArgs e)
    {
        carregarGrid(dtoDaTela());
    }
    
    //criando um metodo protegido que irá carregar o grid
    protected void carregarGrid(ProdutoDTO prodTela)
    {
        ProdutoBLL prodBLL = new ProdutoBLL();
        grdProduto.DataSource = prodBLL.buscaTodos(prodTela);
        grdProduto.DataBind();
            }

    protected ProdutoDTO dtoDaTela()
    {
        ProdutoDTO prodTela = new ProdutoDTO();
        prodTela.dsdescricao = txtDescricao.Text;
        prodTela.dsfornecedor = txtFornecedor.Text;
        prodTela.vlvalor = float.Parse(txtPreco.Text);
        prodTela.qtestoque = int.Parse(txtEstoque.Text);

        return prodTela;
    }


    protected void btnInserir_Click(object sender, EventArgs e)
    {
        Session["idproduto"] = "";
        Response.Redirect("ProdutoAlterar.aspx");
    }

    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        Session["idproduto"] = lblid.Text;
        Response.Redirect("ProdutoAlterar.aspx");
    }

    protected void grdProduto_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdProduto.PageIndex = e.NewPageIndex;
        carregarGrid(dtoDaTela());
    }

    protected void grdProduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = grdProduto.SelectedIndex;
        lblid.Text = grdProduto.DataKeys[index].Value.ToString();
    }
}