using Comex_Modelos.Banco;
using Comex_Modelos.Modelos;

namespace Comex_Modelos.Menus;

internal class MenuDeletarProduto : MenuPrincipal
{
    public async override Task Executar()
    {
        Console.WriteLine("\nDigite o id do produto a ser deletado:");
        string leIdProduto = Console.ReadLine()!;
        int leIdProdutoNumerico = int.Parse(leIdProduto);

        Produto produto = new Produto(leIdProdutoNumerico);
        new ProdutoDAL().Deletar(produto);
        
        Console.WriteLine("\nProduto Deletado com Sucesso!");
        Thread.Sleep(1000);
        Console.Clear();
    }
}
