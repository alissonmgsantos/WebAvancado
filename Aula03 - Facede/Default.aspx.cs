using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnVerificar_Click(object sender, EventArgs e)
    {
        Pessoa pessoa = new Pessoa(txtNome.Text, txtCpf.Text);
        double valor = Convert.ToDouble(txtEmprestimo.Text);

        FacedeCredito credito = new FacedeCredito();

        lblResultado.Text = credito.VerificaSituacaoFinanceira(pessoa, valor);

    }

    protected void btnLimpar_Click(object sender, EventArgs e)
    {
        txtNome.Text = "";
        txtCpf.Text = "";
        txtEmprestimo.Text = "";
        lblResultado.Text = "";
    }
}