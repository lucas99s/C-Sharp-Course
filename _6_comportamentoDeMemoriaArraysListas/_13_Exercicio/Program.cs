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

            Console.WriteLine($"Matrix: {matrix.GetLength(0)}, {matrix.GetLength(1)}");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            int searchValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] == searchValue)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Position: {i}, {j}");
                        if(i - 1 >= 0) {
                            Console.WriteLine($"Top: {matrix[i - 1, j]}");
                        }
                        if(i + 1 < matrix.GetLength(0))
                        {
                            Console.WriteLine($"Bottom: {matrix[i + 1, j]}");
                        }
                        if(j - 1 >= 0)
                        {
                            Console.WriteLine($"Left: {matrix[i, j - 1]}");
                        }
                        if(j + 1 < matrix.GetLength(1) )
                        {
                            Console.WriteLine($"Right: {matrix[i, j + 1]}");
                        }
                    }
                }
            }
        }
    }
}
