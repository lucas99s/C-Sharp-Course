using System;

//Exercício de câmbio monetário

namespace _11_Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine());

            double reais = ConversorDeMoeda.ComprarDolares(cotacao, dolares);
            Console.WriteLine($"Valor a ser pago em reais = {reais:F2}");
        }
    }
}
