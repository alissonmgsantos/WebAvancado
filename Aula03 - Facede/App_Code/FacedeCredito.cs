using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FacedeCredito
/// </summary>
public class FacedeCredito
{
    private Serasa serasa = new Serasa();
    private Spc spc = new Spc();
    private DataPrev dataPrev = new DataPrev();
    public FacedeCredito()
    {

    }

    public string VerificaSituacaoFinanceira(Pessoa pessoa, double valor)
    {
        string retorno = "";
        retorno += "<br/>" + serasa.EstaNoSerasa(pessoa);
        retorno += "<br/>" + spc.EstaNoSpc(pessoa);
        retorno += "<br/>" + dataPrev.PossuiLimiteCredito(pessoa, valor);



        return retorno;
    }

}