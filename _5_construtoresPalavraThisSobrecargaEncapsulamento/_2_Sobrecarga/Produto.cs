using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Sobrecarga
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() { } // Construtor padrão

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5; // Você pode tanto passar um valor padrão, quanto dispensar essa linha que por padrão será atribuído o valor de 0;
        }

        //Usos do this
        public Produto(string Nome, double Preco, int Quantidade) : this(Nome, Preco) //Reaproveitando o construtor de dois atributos acima.
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            this.Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            this.Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}, R$ {Preco:F2}, {Quantidade} unidades, Total: {ValorTotalEmEstoque():F2}";
        }
    }
}
