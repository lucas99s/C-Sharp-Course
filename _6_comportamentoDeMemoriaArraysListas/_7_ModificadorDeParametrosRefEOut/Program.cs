using System;

namespace _7_ModificadorDeParametrosRefEOut
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 3;
            Calculator.Double(a);
            Console.WriteLine(a);

            int b = 3;
            Calculator.Triple(ref b);
            Console.WriteLine(b);

            int c = 3;
            int result;
            Calculator.Quadruple(c, out result);
            Console.WriteLine(result);
        }
    }
}
