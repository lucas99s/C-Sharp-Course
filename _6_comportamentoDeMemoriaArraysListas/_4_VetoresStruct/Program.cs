using System;

namespace _4_VetoresStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for(int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(vect[i]);
            }
        }
    }
}
