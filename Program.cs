using comex.Modelos;

int opcao = 0;

while (opcao != 3)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Criar Produto");
    Console.WriteLine("2 - Listar Produtos");
    Console.WriteLine("3 - Sair");
    string leOpcao = Console.ReadLine()!;
    int leOpcaoNumerica = int.Parse(leOpcao);

    switch (leOpcaoNumerica)
    {
        case 1:
            ManipulaProduto criaProduto = new ManipulaProduto();
            criaProduto.CriarProduto();
            break;

        case 2:
            ManipulaProduto listaProduto = new ManipulaProduto();
            listaProduto.ListarProdutos();
            break;

        case 3:
            Console.WriteLine("Até mais!");
            Thread.Sleep(1000);
            opcao = 3;
            break;

        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}