using System;

namespace _3_VetoresEmClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos?");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for(int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                vect[i] = new Produto { Nome = nome, Preco = preco }; //Além de instanciar o vetor produto acima, precisa instanciar cada posição do vetor, o que não é necessário em vetores struct
            }

            double sum = 0;

            for(int i = 0; i < n; i++)
            {
                sum += vect[i].Preco;
            }

            double avg = sum / n;
            Console.WriteLine($"Preço médio é: {avg:F2}");
        }
    }
}
