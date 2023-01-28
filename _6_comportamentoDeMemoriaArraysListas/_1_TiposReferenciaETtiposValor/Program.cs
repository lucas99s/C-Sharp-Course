using System;

namespace _1_TiposReferenciaETtiposValor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p; //new Ponto() > por estar usando struct, esse código não é mais necessário pra ser inicializada

            p.x = 10;
            p.y = 12;
            Console.WriteLine(p);

            p = new Ponto();
            Console.WriteLine(p);
        }
    }
}
