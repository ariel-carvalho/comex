namespace comex.Modelos;

internal class Produto
{
    public string Nome { get; }

    public static List<string> produtos = new List<string>();

    public Produto(string nome)
    {
        Nome = nome;
    }    
}