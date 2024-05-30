using comex.Modelos;

namespace comex.Menus;

internal class MenuListarProduto: MenuPrincipal
{
    public override void Executar()
    {
        Console.WriteLine("Lista de Produtos:");
        Console.WriteLine(Produto.produtos.ToString());
        foreach (string produto in Produto.produtos)
        {
            Console.WriteLine($"Produtos: {produto}");
        }
        Console.WriteLine("");
    }
}
