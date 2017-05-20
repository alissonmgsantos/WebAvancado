using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProdutoAlterar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblid.Text = Session["idproduto"].ToString();
        }
    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProdutoListagem.aspx");
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        ProdutoBLL prodBLL = new ProdutoBLL();
        ProdutoDTO prodTela = new ProdutoDTO();
        prodTela.dsdescricao = txtDescricao.Text;
        prodTela.dsfornecedor = txtFornecedor.Text;
        prodTela.vlvalor = float.Parse(txtPreco.Text);
        prodTela.qtestoque = int.Parse(txtEstoque.Text);

        if (lblid.Text.Equals(""))
        {
            prodBLL.cadastrar(prodTela);
        }else
        {
            prodTela.idProduto = int.Parse(lblid.Text);
            prodBLL.alterar(prodTela);
        }
        Response.Redirect("ProdutoListagem.aspx");
    }
}