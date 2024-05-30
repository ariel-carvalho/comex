using comex.Menus;
using comex.Modelos;
using comex.Ordenacoes;
using System.Text.Json;

MenuPrincipal menuPrincipal = new MenuPrincipal();
menuPrincipal.Executar();

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
        var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta)!;

        for (int i = 0; i < produtos.Count; i++)
        {
            produtos[i].ExibirProduto();
        }

        LinqOrder.OrdenarProdutosPorNome(produtos);

        LinqOrder.OrdenarProdutosPorPreco(produtos);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro! " + ex.Message);
    }
}