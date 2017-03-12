using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataPrev
/// </summary>
public class DataPrev
{
    public DataPrev()
    {

    }

    public string PossuiLimiteCredito(Pessoa pessoa, double valor)
    {
        string retorno = pessoa.Nome + " com " + pessoa.Cpf;
        if (valor > 5000.00)
        {
            retorno += " Consulta de crédito NEGADO";
        }
        else
        {
            retorno += " Consulta de crédito APROVADO";
        }

        return retorno;
    }
}