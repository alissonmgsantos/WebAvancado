using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Serasa
/// </summary>
public class Serasa
{
    public Serasa()
    {

    }

    public string EstaNoSerasa(Pessoa pessoa)
    {
        string aux = "";
        if (pessoa.Cpf[0].Equals('1'))
        {
            aux = "NEGADO";
        }
        else
        {
            aux = "LIBERADO";
        }
        return pessoa.Nome + " Consultado(a) no Serasa - " + aux;
    }


}