namespace comex.Modelos;

internal class Livro : Produto
{   
    public string Isbn { get; }
    public int TotalDePaginas { get; }

    public Livro(string nome, double preco, int quantidade) : base(nome, preco, quantidade)
    {
        
    }

    public override void Identificar()
    {
        Console.WriteLine("Nome do Livro: " + Nome);
        Console.WriteLine("ISBN do Livro: " + Isbn);
    }
}
