using System;
using System.Globalization;

namespace _1_ResolvendoUmProblemaSemPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double perimetroX = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(perimetroX * (perimetroX - xA) * (perimetroX - xB) * (perimetroX - xC));

            Console.WriteLine("Entre com as medidas do trinângulo Y: ");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double perimetroY = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(perimetroY * (perimetroY - yA) * (perimetroY - yB) * (perimetroY - yC));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
            

        }
    }
}
