using System;
using _2_UpcastingAndDowncasting.Entities;

namespace _2_UpcastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(500, 1002, "Juliana", 5000);

            //UPCASTING

            Account acc1 = bacc; // A superclasse aceita qualquer uma de suas subclasses
            Account acc2 = new BusinessAccount(100, 1003, "Roberta", 200);
            Account acc3 = new SavingsAccount(1004, "Lucas", 4000, 12);

            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2; //acc2 é uma superclasse, e para fazer o downcasting, ou seja, uma subclasse aceitar como variável, precisa fazer um casting.
            acc4.Load(100);

            // BusinessAccount acc5 = (BusinessAccount)acc3; Ao executar vai dar erro, pois ambos são subclasses. Fique atento pois esse erro só aparece em tempo de execução.
            // Abaixo verificamos se acc3 é uma instância de BusinessAccount.
            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }

            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount; //Sintaxe alternativa para o downcasting
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }
        }
    }
}