﻿namespace comex.Modelos;

internal class Eletronico: Produto
{
    public int Voltagem { get; set; }
    public int Potencia { get; set; }

    public Eletronico(string nome, double preco, int quantidade) : base(nome, preco, quantidade)
    {
        
    }
}
