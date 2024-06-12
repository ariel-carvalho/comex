using Comex.Modelos.Modelos;

namespace Comex.Modelos.Menus;

internal class MenuListarProduto : MenuPrincipal
{
    public override async Task Executar()
    {
        Console.Clear();
        Console.WriteLine("Lista de Produtos:");
        Produto.ListarProdutos();
        Console.WriteLine("");
    }
}
