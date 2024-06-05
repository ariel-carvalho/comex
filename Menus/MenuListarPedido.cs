using comex.Modelos;

namespace comex.Menus;

internal class MenuListarPedido: MenuPrincipal
{
    public override void Executar()
    {
        Console.Clear();    
        Pedido.ListarPedidos();
        Console.WriteLine($"\nTotal Geral: {Pedido.CalculaTotalDaListaDePedidos()}");
        Console.WriteLine("");       
    }
}
