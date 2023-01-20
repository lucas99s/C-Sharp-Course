using System;

namespace _5_Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p;
            p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

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
