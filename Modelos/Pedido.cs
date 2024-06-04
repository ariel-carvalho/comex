using System.Linq;
using System.Threading.Channels;

namespace comex.Modelos;

internal class Pedido
{
    public Cliente Cliente {  get; }
    public DateTime Data { get; }
    public List<ItemDePedido> Itens = new List<ItemDePedido>();
    public decimal Total { get; set; }

    public Pedido(Cliente cliente, DateTime data)
    {
        Cliente = cliente;
        Data = data;
    }

    public void AdcionarItem(ItemDePedido itemDePedido)
    {
        Itens.Add(itemDePedido);
    }

    public decimal CalculaTotal()
    {
        decimal total = 0;

        foreach (var item in Itens)
        {
            total += item.CalculaSubtotal();
        }

        return total;
    }

    public void ListarItens()
    {
        foreach (var item in Itens)
        {
            Console.WriteLine(item);
        }
    }

    public override string ToString()
    {
        Console.WriteLine($"Cliente\n{Cliente}\n");
        Console.WriteLine($"Data\n{Data}\n");
        Console.WriteLine("Itens ");
        ListarItens();
        return $"\nTotal\n{CalculaTotal()}\n";


    }
}
