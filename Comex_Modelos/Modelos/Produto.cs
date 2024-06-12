using System.Text.Json.Serialization;

namespace Comex.Modelos.Modelos;

public class Produto : IIdentificavel
{
    [JsonPropertyName("id")]
    public int Id { get; }
    [JsonPropertyName("title")]
    public string Nome { get; }
    [JsonPropertyName("price")]
    public decimal Preco { get; }
    [JsonPropertyName("count")]
    public int Quantidade { get; }


    public static List<string> Produtos = new List<string>();

    public Produto(string nome, int quantidade, decimal preco)
    {
        Nome = nome;
        Quantidade = quantidade;
        Preco = preco;
    }

    public void ExibirProduto()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Preço: " + Preco);
        Console.WriteLine("Quantidade: " + Quantidade);
    }

    public virtual void Identificar()
    {

    }

    public static void ListarProdutos()
    {
        foreach (string produto in Produtos)
        {
            Console.WriteLine($"Produto: {produto}");
        }
    }

    public override string ToString()
    {
        return Nome;
    }
}