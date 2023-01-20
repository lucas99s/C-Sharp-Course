using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Exercicio_2
{
    class Funcionario
    {
        public string Nome;
        public double Salario;

        public double Media(double Salario)
        {
            double Media = (this.Salario + Salario) / 2;
            return Media;
        }
    }
}
