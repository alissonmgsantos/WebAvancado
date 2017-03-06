using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class resultado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {   //Exibirá por meio de sessão o resultado do calculo IMC
        lblResultado.Text = "Resultado = " + Session["resultado"];
    }


    protected void btnVoltar_Click(object sender, EventArgs e)
    {  //Retorna para a pagina Default
        Response.Redirect("Default.aspx");

    }
}