using System;

namespace _9_MembrosEstaticos
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio: ");

            double Raio = double.Parse(Console.ReadLine());
            double Circ = Circunferencia(Raio);
            double Vol = Volume(Raio);

            Console.WriteLine($"Circunferência: {Circ:F2}");
            Console.WriteLine($"Volume: {Vol:F2}");
            Console.WriteLine("Pi: " + Pi);
        }

        static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
