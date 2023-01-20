using System;

//Sistema que da a área, perimetro e diagonal de um retangulo

namespace _6_Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;
            r = new Retangulo();

            Console.WriteLine("Entre com as medidas do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine(r);

        }
    }
}
