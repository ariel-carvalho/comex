namespace comex.Modelos;

internal class ManipulaProduto
{
    public void CriarProduto()
    {
        Console.WriteLine("Digite o nome do produto:");
        string leProduto = Console.ReadLine()!;
        Produto produto = new Produto(leProduto);
        Produto.produtos.Add(produto.Nome);
        Console.WriteLine("Produto Criado com Sucesso!");
        Thread.Sleep(1000);
        Console.Clear();
    }

    public void ListarProdutos()
    {
        Console.WriteLine("Lista de Produtos:");
        Console.WriteLine(Produto.produtos);
        foreach (string produto in Produto.produtos)
        {
            Console.WriteLine($"Produtos: {produto}");
        }
    }
}
