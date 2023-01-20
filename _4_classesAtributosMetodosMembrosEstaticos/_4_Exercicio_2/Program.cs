using System;

//Exercício 2 do pdf;

namespace _4_Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Salário médio = " + x.Media(y.Salario));
        }
    }
}
