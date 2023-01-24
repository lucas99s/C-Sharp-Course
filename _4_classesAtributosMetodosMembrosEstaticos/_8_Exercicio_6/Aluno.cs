using System;

namespace _8_Exercicio_6
{
    class Aluno
    {
        public string Nome;
        private double Nota1;
        private double Nota2;
        private double Nota3;
        private string Aprovacao;

        public void DefinirNota(int Trimestre, double Nota)
        {
            if (Trimestre == 1)
            {
                if(Nota <= 30)
                {
                    Nota1 = Nota;
                } 
                else
                {
                    Console.WriteLine("Nota nao pode ser maior que 30.");
                    Console.Write("Tente novamente: ");
                    DefinirNota(1, double.Parse(Console.ReadLine()));
                }
            } 
            else if (Trimestre == 2 || Trimestre == 3)
            {
                if (Nota <= 35)
                {
                    if (Trimestre == 2)
                    {
                        Nota2 = Nota;
                    } 
                    else
                    {
                        Nota3 = Nota;
                        Resultado(Nota1, Nota2, Nota3);
                    }
                }
                else
                {
                    Console.WriteLine("Nota nao pode ser maior que 35.");
                    Console.Write("Tente novamente: ");
                    if (Trimestre == 2)
                    {
                        DefinirNota(2, int.Parse(Console.ReadLine()));
                    }
                    else
                    {
                        DefinirNota(3, int.Parse(Console.ReadLine()));
                    }
                    
                }
            }
        }

        private void Resultado(double n1, double n2, double n3)
        {
            double Final = n1 + n2 + n3;
            if(Final >= 60)
            {
                Aprovacao = "Aprovado";
            } else
            {
                Aprovacao = "Reprovado";
                Console.WriteLine($"Faltaram: {(Final - 60) * -1:F2} pontos");
            }
            Console.WriteLine($"Nota final = {Final:F2}");
            Console.WriteLine($"{Aprovacao}");
        }
    }
}
