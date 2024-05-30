using System.Text.Json.Serialization;

namespace comex.Modelos;

internal class Produto : IIdentificavel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("title")]
    public string Nome { get; }
    [JsonPropertyName("price")]
    public double Preco { get; set; }
    [JsonPropertyName("count")]
    public int Quantidade { get; set; }


    public static List<string> produtos = new List<string>();

    public Produto(string nome)
    {
        Nome = nome;
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
}