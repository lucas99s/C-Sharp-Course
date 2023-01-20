using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Exercicio_3
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
