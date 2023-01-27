using System;

namespace _3_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 900.00, 10);

            p.Nome = "TV 4K";
            p.Nome = "T"; // Por causa do filtro, ele não permite nomear essa variável com apenas um caractere ou menos.

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
