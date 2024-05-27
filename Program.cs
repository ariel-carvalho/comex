using comex;

Endereco endereco1 = new Endereco();
endereco1.bairro = "Bairro 1";
endereco1.cidade = "Cidade 1";
endereco1.complemento = "Complemento 1";
endereco1.estado = "Estado1";
endereco1.rua = "Rua 1";
endereco1.numero = 1;

Cliente cliente1 = new Cliente();
cliente1.nome = "Cliente 1";
cliente1.cpf = "123.456.789-10";
cliente1.email = "cliente1@email.com";
cliente1.profissao = "Profissão 1";
cliente1.telefone = "(11) 1234-56789";
cliente1.endereco = endereco1;

Console.WriteLine("Nome: " + cliente1.nome);
Console.WriteLine("CPF: " + cliente1.cpf);
Console.WriteLine("E-mail: " + cliente1.email);
Console.WriteLine("Profissão: " + cliente1.profissao);
Console.WriteLine("Telefone: " + cliente1.telefone);
Console.WriteLine("Bairro: " + cliente1.endereco.bairro);
Console.WriteLine("Cidade: " + cliente1.endereco.cidade);
Console.WriteLine("Complemento: " + cliente1.endereco.complemento);
Console.WriteLine("Estado: " + cliente1.endereco.estado);
Console.WriteLine("Rua: " + cliente1.endereco.rua);
Console.WriteLine("Número: " + cliente1.endereco.numero);

Console.WriteLine("\n**************************\n");

Produto produto1 = new Produto("Produto 1");

Console.WriteLine("Nome: " + produto1.Nome);

Console.WriteLine("\n**************************\n");

int opcao = 0;
List<string> produtos = new List<string>();

while (opcao != 3)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Criar Produto");
    Console.WriteLine("2 - Listar Produtos");
    Console.WriteLine("3 - Sair");
    string leOpcao = Console.ReadLine()!;
    int LeOpcaoNumerica = int.Parse(leOpcao);

    switch (LeOpcaoNumerica)
    {
        case 1:
            CriarProduto();
            break;

        case 2:
            ListarProdutos();
            break;

        case 3:
            Sair();
            break;

        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

void CriarProduto()
{
    Console.WriteLine("Digite o nome do produto:");
    string leProduto = Console.ReadLine()!;
    Produto produto = new Produto(leProduto);
    produtos.Add(produto.Nome);
    Console.WriteLine("Produto Criado com Sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
}

void ListarProdutos()
{
    Console.WriteLine("Lista de Produtos:");
    Console.WriteLine(produtos);
    foreach (string produto in produtos)
    {
        Console.WriteLine($"Produtos: {produto}");
    }
}
void Sair()
{
    Console.WriteLine("Até mais!");
    opcao = 3;
    Thread.Sleep(1000);
}