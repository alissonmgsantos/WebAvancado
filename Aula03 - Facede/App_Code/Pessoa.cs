using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Pessoa
/// </summary>
public class Pessoa
{
    public string Nome { get; set; }
    public string Cpf { get; set; }

    public Pessoa(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }
}