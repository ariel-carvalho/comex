using System.Text.Json.Serialization;

namespace comex.Modelos;

internal class Produto : IIdentificavel
{
    [JsonPropertyName("id")]
    public int Id { get; }
    [JsonPropertyName("title")]
    public string Nome { get; }
    [JsonPropertyName("price")]
    public double Preco { get; }
    [JsonPropertyName("count")]
    public int Quantidade { get; }


    public static List<string> produtos = new List<string>();

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
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

    public override string ToString()
    {
        return Nome;
    }
}