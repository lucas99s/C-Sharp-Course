using System;
using _1_Heranca.Entities;

namespace _1_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(3500, 8080, "Lucas", 15000);

            Console.WriteLine(account.Balance);

            //account.Balance = 200; Não vai funcionar pois é uma variável protected, ou seja, a própria classe e subclasses podem modificá-la externamente, mas outras classes como essa não.
        }
    }
}
