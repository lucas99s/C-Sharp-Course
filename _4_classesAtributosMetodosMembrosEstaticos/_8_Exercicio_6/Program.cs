using System;

//Sistema que calcula as notas dos três trimestres e dá o resultado se foi aprovado ou reprovado. Se reprovado, ele mostrará quantos pontos faltaram para ser aprovado.

namespace _8_Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno f;
            f = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            f.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno");
            Console.Write("Primeiro trimestre: ");
            f.DefinirNota(1, double.Parse(Console.ReadLine()));
            Console.Write("Segundo trimestre: ");
            f.DefinirNota(2, double.Parse(Console.ReadLine()));
            Console.Write("Terceiro trimestre: ");
            f.DefinirNota(3, double.Parse(Console.ReadLine()));
        }
    }
}
