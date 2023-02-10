using System;

namespace _12_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tamanho da matriz em linhas e colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < matriz.GetLength(0); j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal:");
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"{matriz[i,i]} ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    if(matriz[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Números negativos: {count}");

        }
    }
}
