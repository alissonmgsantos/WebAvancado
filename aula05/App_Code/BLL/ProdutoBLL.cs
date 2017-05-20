using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
/// <summary>
/// Summary description for ProdutoBLL
/// </summary>
public class ProdutoBLL : AcessoDAL
{
    private OleDbCommand command;
    private OleDbDataReader drOleDb;
    private OleDbDataAdapter daOleDb;
    private DataSet dsOleDb;
    public String erro { get; set; }

    public ProdutoBLL()
    {

    }
    private String montaQuery(ProdutoDTO produto)
    {
        String sql = "SELECT idProduto,dsdescricao,vlvalor,dsfornecedor, qtestoque FROM tbProduto WHERE 1=1";

        if (produto.idProduto > 0)
        {
            sql += "AND idProduto = " + produto.idProduto;
        }
        if (produto.dsdescricao.Trim() != "") //Trim garante que a variavel não tenha espaços em branco no inicio e no final da consulta;
        {
            sql += "AND dsdescrecao LIKE '%" + produto.dsdescricao.Trim() + "%'";
        }
        if (produto.vlvalor != 0.0)
        {
            sql += "AND vlvalor = " + produto.vlvalor;
        }

        if (produto.dsfornecedor.Trim() != "")
        {
            sql += "AND dsfornecedor LIKE '%" + produto.dsfornecedor.Trim() + "%'";
        }

        if (produto.qtestoque > 0)
        {
            sql += "AND qtestoque = " + produto.qtestoque;
        }

        return sql;
    }

    public ProdutoDTO buscaPorID(ProdutoDTO prod)
    {
        String sql = montaQuery(prod);

        ProdutoDTO prodRet = new ProdutoDTO();
        try
        {
            drOleDb = criaDataReader(sql);
            while (drOleDb.Read())
            {
                prodRet.idProduto = (int)drOleDb["idProduto"];
                prodRet.dsdescricao = (String)drOleDb["dsdescricao"];
                prodRet.vlvalor = (double)drOleDb["vlvalor"];
                prodRet.dsfornecedor = (String)drOleDb["dsfornecedor"];
                prodRet.qtestoque = (int)drOleDb["qtEstoque"];
            }

        }
        catch (SystemException e)
        {
            this.erro = e.Message;
        }

        return prodRet;
    }


    public ListaDeProdutos buscaTodos(ProdutoDTO prod)
    {
        ListaDeProdutos listaRet = new ListaDeProdutos();
        String sql = this.montaQuery(prod);
        try
        {
            drOleDb = criaDataReader(sql);
            while (drOleDb.Read())
            {
                ProdutoDTO dtoAux = new ProdutoDTO();
                dtoAux.idProduto = (int)drOleDb["idProduto"];
                dtoAux.dsdescricao = (String)drOleDb["dsdescricao"];
                dtoAux.vlvalor = (double)drOleDb["vlvalor"];
                dtoAux.dsfornecedor = (String)drOleDb["dsfornecedor"];
                dtoAux.qtestoque = (int)drOleDb["qtestoque"];

                listaRet.Add(dtoAux);
            }
        }
        catch (SystemException e)
        {
            erro = e.Message;
        }
        return listaRet;
    }

    private int maxId() // Irá pegar o ID maximo da tabela
    {
        String sSql = "SELECT Max(*) FROM tbProduto";
        int idretorno = 1;
        try
        {
            drOleDb = criaDataReader(sSql);
            while (drOleDb.Read())
            {
                if (!DBNull.Value.Equals(drOleDb[0]))
                {
                    idretorno = (int)drOleDb[0];
                }
            }
        }
        catch (SystemException e)
        {
            erro = e.Message;
        }
        return idretorno;
    }

    public void cadastrar(ProdutoDTO prod)
    {
        int idproduto = this.maxId();
        string sql = "";
        sql += "INSERT INTO tbProduto (idproduto, dsDescricao, vlvalor, dsfornecedor, qtestoque) VALUES (@idproduto, @descricao, @valor, @fornecedor, @estoque)";

        command = criaDbCommand(sql, CommandType.Text);

        command.Parameters.AddWithValue("@idproduto", idproduto);
        command.Parameters.AddWithValue("@descricao", prod.dsdescricao);
        command.Parameters.AddWithValue("@valor", prod.vlvalor);
        command.Parameters.AddWithValue("@fornecedor", prod.dsfornecedor);
        command.Parameters.AddWithValue("@estoque", prod.qtestoque);



        //OleDbParameter parametro = command.Parameters.Add("RETURN_VALUE", OleDbType.Integer);
        //parametro.Direction = ParameterDirection.ReturnValue;

        //parametro = command.Parameters.Add("@descricao", OleDbType.VarChar);
        //parametro.Value = prod.descricao;

        //parametro = command.Parameters.Add("@valor", OleDbType.Double);
        //parametro.Value = prod.valor;

        //parametro = command.Parameters.Add("@fornecedor", OleDbType.VarChar);
        //parametro.Value = prod.fornecedor;

        try
        {
            //drOleDb = command.ExecuteReader();
            command.ExecuteNonQuery();
            drOleDb.Close();
            //int idAtual = (int)command.Parameters["RETURN_VALUE"].Value;
        }
        catch (SystemException e)
        {
            erro = e.Message;
        }
      }

    public void alterar(ProdutoDTO prod)
    {
        String sql = "";
        sql += "UPDATE FROM tbProduto SET (dsdescricao = @descricao, vlvalor = @valor, dsfornecedor = @fornecedor, qtestoque = @estoque) WHERE idProduto = @idProduto";

        command = criaDbCommand(sql, CommandType.Text);
        OleDbParameter parametro = command.Parameters.Add("@idProduto", OleDbType.Integer);
        parametro.Value = prod.idProduto;

        parametro = command.Parameters.Add("@descricao", OleDbType.VarChar);
        parametro.Value = prod.dsdescricao;

        parametro = command.Parameters.Add("@valor", OleDbType.Double);
        parametro.Value = prod.vlvalor;

        parametro = command.Parameters.Add("@fornecedor", OleDbType.VarChar);
        parametro.Value = prod.dsfornecedor;

        parametro = command.Parameters.Add("@estoque", OleDbType.Integer);
        parametro.Value = prod.qtestoque;

        try
        {
            drOleDb = command.ExecuteReader();
            drOleDb.Close();
        }
        catch (SystemException e)
        {
            erro = e.Message;
        }
    }

    public void excluir (ProdutoDTO prod)
    {
        String sql = "";
        sql += "DELETE FROM tbProduto WHERE idProduto = @idProduto";

        command = criaDbCommand(sql, CommandType.Text);
        OleDbParameter parametro = command.Parameters.Add("@idProduto", OleDbType.Integer);
        parametro.Value = prod.idProduto;
        
        try
        {
            drOleDb = command.ExecuteReader();
            drOleDb.Close();
        }
        catch (SystemException e)
        {
            erro = e.Message;
        }
    }
}