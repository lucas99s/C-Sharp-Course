using System;
using System.Collections.Generic;
using System.Text;

namespace _7_ModificadorDeParametrosRefEOut
{
    class Calculator
    {
        
        public static void Double(int x)
        {
            x = x * 2;
        }

        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Quadruple(int origin, out int result)
        {
            result = origin * 4;
        }
    }
}
