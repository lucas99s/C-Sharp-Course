using System;

//Melhorando o código do exercício do módulo anterior. Usando construtor não é possível iniciar uma instância de um produto sem valores.

namespace _1_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade); //Construtor

            Console.WriteLine($"Dados do produto: {p}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados: {p}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados atualizados: {p}");
        }
    }
}
