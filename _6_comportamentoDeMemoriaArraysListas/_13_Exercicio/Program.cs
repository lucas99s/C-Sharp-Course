using System;

//Fazer um programa para ler dois números inteiros M e N, depois ler uma matriz de M linhas por N colunas contendo números inteiros, podendo haver repetições.
//Em seguida, ler um número inteiro X que pertence à matriz. Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver.

namespace _13_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine("Matrix: ");
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            int searchValue = int.Parse(Console.ReadLine());
            int top;
            int bottom;
            int left;
            int right;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] == searchValue)
                    {
                        Console.WriteLine("Position: " + matrix[i, j]);
                        top = matrix[i - 1, j];
                        bottom = matrix[i + 1, j];
                        left = matrix[i, j - 1];
                        right = matrix[i, j + 1];

                        Console.WriteLine($"Top: {top}");
                        Console.WriteLine($"Bottom: {bottom}");
                        Console.WriteLine($"Left: {left}");
                        Console.WriteLine($"Right: {right}");
                    }
                }
            }
        }
    }
}
