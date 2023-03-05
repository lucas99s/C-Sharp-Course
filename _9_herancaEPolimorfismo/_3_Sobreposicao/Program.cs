using System;
using _3_Sobreposicao.Entities;

namespace _3_Sobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1000, "Lucas", 500);
            Account acc2 = new SavingsAccount(1001, "Anna", 500, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
