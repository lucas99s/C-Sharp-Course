using System;

//Continuação da aula de membros estáticos.

namespace _10_MembrosEstaticos_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio: ");

            double Raio = double.Parse(Console.ReadLine());
            double Circ = Calculadora.Circunferencia(Raio);
            double Vol = Calculadora.Volume(Raio);

            Console.WriteLine($"Circunferência: {Circ:F2}");
            Console.WriteLine($"Volume: {Vol:F2}");
            Console.WriteLine("Pi: " + Calculadora.Pi);
        }


    }
}
