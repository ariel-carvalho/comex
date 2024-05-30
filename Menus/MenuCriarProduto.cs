using comex.Modelos;

namespace comex.Menus;

internal class MenuCriarProduto: MenuPrincipal
{
    public override void Executar()
    {
        Console.WriteLine("\nDigite o nome do produto:");
        string leProduto = Console.ReadLine()!;
        Produto produto = new Produto(leProduto);
        Produto.produtos.Add(produto.Nome);
        Console.WriteLine("Produto Criado com Sucesso!");
        Thread.Sleep(1000);
        Console.Clear();
    }
}
