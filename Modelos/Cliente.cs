namespace comex.Modelos;

internal class Cliente: IIdentificavel
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco { get; set; }

    public void Identificar()
    {
        Console.WriteLine("Nome do Cliente: " + Nome);
        Console.WriteLine("CPF do Cliente: " + Cpf);
    }

    public void MostraCliente()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("CPF: " + Cpf);
        Console.WriteLine("E-mail: " + Email);
        Console.WriteLine("Profissão: " + Profissao);
        Console.WriteLine("Telefone: " + Telefone);
        Console.WriteLine("Bairro: " + Endereco.Bairro);
        Console.WriteLine("Cidade: " + Endereco.Cidade);
        Console.WriteLine("Complemento: " + Endereco.Complemento);
        Console.WriteLine("Estado: " + Endereco.Estado);
        Console.WriteLine("Rua: " + Endereco.Rua);
        Console.WriteLine("Número: " + Endereco.Numero);
    }

    
}
