using comex.Modelos;

namespace comex.Menus;

internal class MenuListarProduto: MenuPrincipal
{
    public override void Executar()
    {
        Console.Clear();
        Console.WriteLine("Lista de Produtos:");
        Produto.ListarProdutos();
        Console.WriteLine("");
    }
}
