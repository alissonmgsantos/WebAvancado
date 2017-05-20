using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for tbVendaDTO
/// </summary>
public class ProdutoDTO
{
    public ProdutoDTO()
    {

    }
    public ProdutoDTO(int idProduto, String descricao, double valor, String fornecedor, int estoque)
    {
        this.idProduto = idProduto;
        this.dsdescricao = descricao;
        this.vlvalor = valor;
        this.dsfornecedor = fornecedor;
        this.qtestoque = estoque;
    }

    public int idProduto { get; set; }
    public String dsdescricao { get; set; }
    public double vlvalor { get; set; }
    public String dsfornecedor { get; set; }

    public Int32 qtestoque { get; set; }
}