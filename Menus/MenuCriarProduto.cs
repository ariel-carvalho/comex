using comex.Modelos;

namespace comex.Menus;

internal class MenuCriarProduto: MenuPrincipal
{
    public override void Executar()
    {
        Console.WriteLine("\nDigite o nome do produto:");
        string leNomeProduto = Console.ReadLine()!;
        
        Console.WriteLine("\nDigite o preço do produto:");
        string lePrecoProduto = Console.ReadLine()!;
        double lePrecoProdutoNumerico = double.Parse(lePrecoProduto);

        Console.WriteLine("\nDigite a quantidade do produto:");
        string leQuantidadeProduto = Console.ReadLine()!;
        int leQuantidadeProdutoNumerico = int.Parse(leQuantidadeProduto);

        Produto produto = new Produto(leNomeProduto, lePrecoProdutoNumerico, leQuantidadeProdutoNumerico);
        Produto.produtos.Add(produto.Nome);
        Console.WriteLine("Produto Criado com Sucesso!");
        Thread.Sleep(1000);
        Console.Clear();
    }
}
