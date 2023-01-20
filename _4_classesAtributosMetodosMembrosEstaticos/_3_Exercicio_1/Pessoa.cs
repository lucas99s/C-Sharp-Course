using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Exercicio_1
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string MaisVelho(int Idade, string Nome)
        {
            string maisVelho;
            if(this.Idade > Idade)
            {
                maisVelho = this.Nome;
            } 
            else
            {
                maisVelho = Nome;
            }

            return "Pessoa mais velha: " + maisVelho;
        }
    }
}
