using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Operacao
/// </summary>
public abstract class Operacao
{
    public abstract int handelOperacao(int val1, int val2);

    /// <summary>
    /// Método que faz operações de dois valores recebidos
    /// </summary>
    /// <param name="val1">Primeiro parametro inteiro</param>
    /// <param name="val2">Segundo parametro inteiro</param>
    /// <returns>Retorna o resultado da operação</returns>
    public int efetuaOperacao(int val1, int val2)
    {
        int resultado = handelOperacao(val1, val2);
        return resultado;
    }

    public Operacao()
    {

    }
}