using Comex_Modelos.Modelos;
using Microsoft.Data.SqlClient;
using System.Text.Json.Serialization;

namespace Comex_Modelos.Banco;

public class ProdutoDAL
{
    public IEnumerable<Produto> Listar()
    {
        var lista = new List<Produto>();

        using var connection = new Connection().ObterConexao();
        connection.Open();

        string sql = "SELECT * FROM produtos";
        SqlCommand command = new SqlCommand(sql, connection);
        using SqlDataReader dataReader = command.ExecuteReader();

        while (dataReader.Read())
        {
            int idProduto = Convert.ToInt32(dataReader["Id"]);
            string nomeProduto = Convert.ToString(dataReader["Nome"])!;
            int quantidadeProduto = Convert.ToInt32(dataReader["Quantidade"]);
            decimal precoProduto = Convert.ToDecimal(dataReader["Preco"]);            
            Produto produto = new Produto(nomeProduto, quantidadeProduto, precoProduto) { Id = idProduto};

            lista.Add(produto);
        }

        return lista;
    }

    public void Adicionar(Produto produto)
    {
        using var connection = new Connection().ObterConexao();
        connection.Open();

        string sql = "INSERT INTO produtos (Nome, Quantidade, Preco) VALUES (@nome, @preco, @quantidade)";
        SqlCommand command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@nome", produto.Nome);
        command.Parameters.AddWithValue("@quantidade", produto.Quantidade);
        command.Parameters.AddWithValue("@preco", produto.Preco);
        command.ExecuteNonQuery();       
    }

    public void Atualizar(Produto produto)
    {
        using var connection = new Connection().ObterConexao();
        connection.Open();

        string sql = $"UPDATE produtos SET Nome = @nome, Quantidade = @quantidade, Preco = @preco WHERE Id = @id";
        SqlCommand command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@nome", produto.Nome);
        command.Parameters.AddWithValue("@quantidade", produto.Quantidade);
        command.Parameters.AddWithValue("@preco", produto.Preco);
        command.Parameters.AddWithValue("@id", produto.Id);
        command.ExecuteNonQuery();
    }

    public void Deletar(Produto produto)
    {
        using var connection = new Connection().ObterConexao();
        connection.Open();

        string sql = $"DELETE FROM produtos WHERE Id = @id";
        SqlCommand command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@id", produto.Id);
        command.ExecuteNonQuery();
    }
}
