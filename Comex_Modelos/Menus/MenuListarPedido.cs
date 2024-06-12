using Comex.Modelos.Modelos;

namespace Comex.Modelos.Menus;

internal class MenuListarPedido : MenuPrincipal
{
    public async override Task Executar()
    {
        Console.Clear();
        Pedido.ListarPedidos();
        Console.WriteLine($"\nTotal Geral: {Pedido.CalculaTotalDaListaDePedidos()}");
        Console.WriteLine("");
    }
}
