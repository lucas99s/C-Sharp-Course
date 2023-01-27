using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Encapsulamento
{
    class Produto
    {
        private string _nome; // No caso dessa variável não da pra usar o auto properties pois existe uma validação que não é comportado pelo auto properties, mas sim no properties (linha 31).
        public double Preco { get; private set; } // Auto properties.
        public int Quantidade { get; private set; }

        public Produto() { } // Construtor padrão

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Usando a forma de encapsulamento, pode-se usar até alguns filtros para definir as variáveis.
        //Esse método é chamado de Properties
        public string Nome
        {
            get { return _nome; }
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

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{_nome}, R$ {Preco:F2}, {Quantidade} unidades, Total: {ValorTotalEmEstoque():F2}";
        }

        //Exemplo de Get e Set sem usar as propriedades

        //public string GetNome()
        //{
        //    return _nome;
        //}

        //public void SetNome(string nome)
        //{
        //    if (nome != null && nome.Length > 1)
        //    {
        //        _nome = nome;
        //    }
        //}
    }
}
