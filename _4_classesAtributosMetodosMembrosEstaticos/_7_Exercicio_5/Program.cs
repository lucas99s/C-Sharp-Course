using System;

//Sistema de funcionário que calcula salário liquido a partir do salário bruto e imposto e calcula o aumento de salário em porcentagem;

namespace _7_Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f;
            f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + f);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}
