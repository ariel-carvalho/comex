using comex.Menus;
using comex.Modelos;
using comex.Ordenacoes;
using System.Text.Json;

#region Atividades da Semana 6
//MenuPrincipal menuPrincipal = new MenuPrincipal();
//menuPrincipal.Executar();

//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
//        var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta)!;

//        for (int i = 0; i < produtos.Count; i++)
//        {
//            produtos[i].ExibirProduto();
//        }

//        LinqOrder.OrdenarProdutosPorNome(produtos);

//        LinqOrder.OrdenarProdutosPorPreco(produtos);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine("Erro! " + ex.Message);
//    }
//}
#endregion

ItemDePedido itemDePedido1 = new ItemDePedido(new Produto("Produto 1", 10, 5), 1, 2);
ItemDePedido itemDePedido2 = new ItemDePedido(new Produto("Produto 2", 20, 10), 2, 4);
ItemDePedido itemDePedido3 = new ItemDePedido(new Produto("Produto 3", 40, 20), 4, 8);

Pedido pedido1 = new Pedido(new Cliente("Cliente 1"), DateTime.Now);
pedido1.AdcionarItem(itemDePedido1);
pedido1.AdcionarItem(itemDePedido2);
pedido1.AdcionarItem(itemDePedido3);
pedido1.CalculaTotal();

Console.WriteLine(pedido1);

