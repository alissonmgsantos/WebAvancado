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

    protected void btnCalcular_Click(object sender, EventArgs e)
    {
        int val1, val2;
        val1 = Convert.ToInt32(txtValor1.Text);
        val2 = Convert.ToInt32(txtValor2.Text);
        Operacao op = null;
        string sResultado = "";

        if (txtOperacao.Text.Equals("Adicao"))
        {
            op = new Adicao();
        }
        else if (txtOperacao.Text.Equals("Subtracao"))
        {
            op = new Subtracao();
        }
        else if (txtOperacao.Text.Equals("Multiplicacao"))
        {
            op = new Multiplicacao();
        }
        else if (txtOperacao.Text.Equals("Divisao"))
        {
            op = new Divisao();
        }
        else
        {
            sResultado = "Operacão inválida";
        }
        if (sResultado.Equals(""))
        {
            sResultado = op.efetuaOperacao(val1, val2).ToString();
        }
        lblResultado.Text = sResultado;

    }

    protected void btnLimpar_Click(object sender, EventArgs e)
    {
        txtValor1.Text = "";
        txtValor2.Text = "";
        txtOperacao.Text = "";
        lblResultado.Text = "";
    }
}