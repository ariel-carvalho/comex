using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comex
{
    internal class Produto
    {
        public string Nome { get; }

        List<string> produtos = new List<string>();

        public Produto(string nome)
        {
            Nome = nome;
        }
    }
}
