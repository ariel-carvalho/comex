using System.Text.Json;
using Comex.Modelos.Modelos;
using Comex.Modelos.Ordenacoes;

namespace Comex.Modelos.Menus;

internal class MenuListarProdutosDaApiExterna : MenuPrincipal
{
    public override async Task Executar()
    {
        await ListarProdutosDaApiExterna();
    }

    async Task ListarProdutosDaApiExterna()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
                var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta)!;

                LinqOrder.OrdenarProdutosPorNome(produtos);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Algo deu errado! " + ex.Message);
            }
        }

        Console.WriteLine("Digite uma tecla para voltar ao menu principal:");
        Console.ReadKey();
    }
}
