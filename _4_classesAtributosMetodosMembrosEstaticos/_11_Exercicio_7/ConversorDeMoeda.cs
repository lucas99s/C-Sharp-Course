using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Exercicio_7
{
    class ConversorDeMoeda
    {
        public static double iof = 0.06;

        public static double ComprarDolares(double cotacao, double dolares)
        {
            double reais = dolares * cotacao;
            return reais + (reais * iof);
        }
    }
}
