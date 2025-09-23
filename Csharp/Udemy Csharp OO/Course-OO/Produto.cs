using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Course_OO
{
    public class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        // public Produto(string nome, double preco, int quantidade)
        // {
        //     Nome = nome;
        //     Preco = preco;
        //     Quantidade = quantidade;
        // }
        public Produto()
        {
        }
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public string Nome
        {
            get
            { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
             + ", $"
             + Preco.ToString("F2", CultureInfo.InvariantCulture)
             + ", "
             + Quantidade
             + " unidades, Total: $ "
             + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}