using System;
using System.Collections.Generic;
using System.Text;

namespace _6_ModificadorDeParametros
{
    class Calculator
    {
        //Ao invés de criar vários construtores com quantidade de parametros
        //diferentes para as várias possibilidades, podemos dessa forma
        //passar quantos parametros quisermos
        public static int Sum(params int[] numbers)
        {

            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
