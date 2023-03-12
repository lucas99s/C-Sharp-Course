using System;
using System.Collections.Generic;
using _7_ClassesAbstratas.Entities;

namespace _7_ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classes abstratas são classes que não podem ser instanciadas.
            //É uma forma de garantir herança total: somente subclasses não abstratas podem ser instanciadas, mas nunca a superclasse abstrata.

            //Mesmo com a Account abstrata, ainda podemos fazer o uso dela, apenas não podemos instanciar, pois vai dar erro.
            List<Account> account = new List<Account>();

            account.Add(new SavingsAccount(1001, "Lucas", 500, 0.01));
            account.Add(new BusinessAccount(1002, "Roberta", 500, 400));
            account.Add(new SavingsAccount(1003, "Luciano", 500, 0.01));
            account.Add(new BusinessAccount(1004, "Talita", 500, 400));

            double sum = 0;
            foreach(Account a in account)
            {
                sum += a.Balance;
            }
            Console.WriteLine(sum);

            foreach(Account a in account)
            {
                a.Withdraw(10);
            }

            foreach (Account a in account)
            {
                Console.WriteLine($"Updated balance of the account: {a.Number}: R$ {a.Balance:F2}");
            }

        }
    }
}
