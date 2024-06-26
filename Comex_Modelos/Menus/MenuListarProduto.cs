using Comex_Modelos.Banco;
using Comex_Modelos.Modelos;

namespace Comex_Modelos.Menus;

internal class MenuListarProduto : MenuPrincipal
{
    public async override Task Executar()
    {
        //Console.Clear();
        //Console.WriteLine("Lista de Produtos:");
        //Produto.ListarProdutos();
        //Console.WriteLine("");
        //Console.WriteLine("Presione uma tecla para voltar ao menu principal");
        //Console.ReadKey();

        try
        {
            Console.WriteLine("\nLista de Produtos:\n");

            var connection = new ProdutoDAL();
            var listaProdutos = connection.Listar();

            foreach (var produto in listaProdutos)
            {
                Console.WriteLine(produto);
            }

            Console.WriteLine("\nPresione uma tecla para voltar ao menu principal");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
