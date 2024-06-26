using Comex_Modelos.Modelos;
using Microsoft.Data.SqlClient;

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
            string nomeProduto = Convert.ToString(dataReader["Nome"]);
            decimal precoProduto = Convert.ToDecimal(dataReader["Preco"]);
            int quantidadeProduto = Convert.ToInt32(dataReader["Quantidade"]);
            Produto produto = new Produto(nomeProduto, quantidadeProduto, precoProduto) { Id = idProduto};

            lista.Add(produto);
        }

        return lista;
    }
}
