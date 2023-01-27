using System;

namespace _2_Sobrecarga
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

            Produto p2 = new Produto(nome, preco);
            Produto p = new Produto(nome, preco, quantidade);
            Produto p3 = new Produto(nome, preco, 20);

            // Sintaxe alternativa. Para ele ser permitido você precisa usar um construtor padrão "public Produto() { }" na classe Produto.
            Produto p4 = new Produto()
            {
                Nome = "TV",
                Preco = 900,
                Quantidade = 40
            };

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
