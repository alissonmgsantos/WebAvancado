using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Adicao
/// </summary>
public class Adicao : Operacao
{
    public Adicao()
    {
        
    }

    public override int handelOperacao(int val1, int val2)
    {
        return val1 + val2;
    }
}