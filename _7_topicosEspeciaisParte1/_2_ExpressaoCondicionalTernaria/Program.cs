using System;

namespace _2_ExpressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor do produto: ");
            double valor = double.Parse(Console.ReadLine());


            double desconto = (valor <= 20) ? valor * 0.1 : valor * 0.2;

            //double desconto;
            //if(valor <= 20)
            //{
            //    desconto = 0.1;
            //} else
            //{
            //    desconto = 0.2;
            //}

            Console.WriteLine($"Desconto R$ {desconto}");
        }
    }
}
