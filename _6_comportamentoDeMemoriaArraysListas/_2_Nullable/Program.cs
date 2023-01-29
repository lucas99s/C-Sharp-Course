using System;

namespace _2_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x = null; //erro, pois double não pode receber valor nulo;
            Nullable<double> x = null;
            double? y = 10; // Melhor maneira para declarar uma variável nullable;

            Console.WriteLine(x.GetValueOrDefault()); // O padrão de double quando está nula é 0;
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x.HasValue)
                Console.WriteLine(x.Value); // Se estiver nulo, esse comando dá erro;
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            double a = x ?? 5; // se x for nulo a variável 'a' será 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
