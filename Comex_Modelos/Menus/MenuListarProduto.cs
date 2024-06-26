using Comex_Modelos.Modelos;

namespace Comex_Modelos.Menus;

internal class MenuListarProduto : MenuPrincipal
{
    public async override Task Executar()
    {
        Console.Clear();
        Console.WriteLine("Lista de Produtos:");
        Produto.ListarProdutos();
        Console.WriteLine("");
        Console.WriteLine("Presione uma tecla para voltar ao menu principal");
        Console.ReadKey();
    }
}
