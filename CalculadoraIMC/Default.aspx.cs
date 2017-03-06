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
        //Criando objeto da classe calculo e passando os valores convertidos dos textBox para as variaveis da classe.
        Calculo calc = new Calculo();
        calc.peso = Convert.ToDouble(txtPeso.Text);
        calc.altura = Convert.ToDouble(txtAltura.Text);

        //Passando o resultado do método para a session e exibindo em outra pagina
        Session["resultado"] = calc.CalculoIMC();
        Response.Redirect("resultado.aspx");
    }

}