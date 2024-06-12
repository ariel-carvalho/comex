using Comex.Modelos.Modelos;

namespace Comex.Modelos.Menus;

internal class MenuCriarProduto : MenuPrincipal
{
    public async override Task Executar()
    {
        Console.WriteLine("\nDigite o nome do produto:");
        string leNomeProduto = Console.ReadLine()!;

        Console.WriteLine("\nDigite o preço do produto:");
        string lePrecoProduto = Console.ReadLine()!;
        decimal lePrecoProdutoNumerico = decimal.Parse(lePrecoProduto);

        Console.WriteLine("\nDigite a quantidade do produto:");
        string leQuantidadeProduto = Console.ReadLine()!;
        int leQuantidadeProdutoNumerico = int.Parse(leQuantidadeProduto);

        Produto produto = new Produto(leNomeProduto, leQuantidadeProdutoNumerico, lePrecoProdutoNumerico);
        Produto.Produtos.Add(produto.Nome);
        Console.WriteLine("\nProduto Criado com Sucesso!");
        Thread.Sleep(1000);
        Console.Clear();
    }
}
