using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Sobreposicao.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Saque sem desconto

        //public override void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //}

        //Saque com desconto da superclasse + desconto posterior na subclasse.
        //Ou seja, base executará a função Withdraw da superclasse, e depois o que estiver nessa abaixo.
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
