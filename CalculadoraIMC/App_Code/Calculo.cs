using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Calculo
/// </summary>
public class Calculo
{
    public double peso { get; set; }
    public double altura { get; set; }
    public Calculo()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary>
    /// Realiza o calculo de indíce de massa corporea
    /// </summary>
    /// <returns></returns>
    public double CalculoIMC()
    {
        double resultado = 0;
        resultado = peso / Math.Pow(altura, 2);

        return resultado;
    }
}