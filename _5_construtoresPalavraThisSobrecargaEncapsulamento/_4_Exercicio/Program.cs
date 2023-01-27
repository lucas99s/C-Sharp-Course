using System;

//Minha solução para o exercício proposto

namespace _4_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c;

            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá um depósito inicial (s/n)?");
            char depositoInicial = char.Parse(Console.ReadLine());

            if(depositoInicial == 's' || depositoInicial == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());

                c = new ContaBancaria(titular, conta, deposito);
            }
            else
            {
                c = new ContaBancaria(titular, conta);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.WriteLine();

            Console.Write("Entre o valor para depósito: ");
            c.Depositar(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
            
            Console.WriteLine();

            Console.Write("Entre o valor para saque: ");
            c.Sacar(double.Parse(Console.ReadLine()));

            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

        }
    }
}
