using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Spc
/// </summary>
public class Spc
{
    public Spc()
    {

    }

    public string EstaNoSpc(Pessoa pessoa)
    {
        string aux = "";
        if (pessoa.Cpf.Length > 11)
        {
            aux = "NEGADO";
        }
        else
        {
            aux = "LIBERADO";
        }
        return pessoa.Nome + " Consultado(a) no SPC - " + aux;
    }
}