using System;
using System.Collections.Generic;
using System.Text;

namespace _4_ClassesEMetodosSelados.Entities
{
    //Sealed serve pra evitar que os métodos e classes sejam sobrepostos múltiplas vezes.
    //Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas pode ser porta de entrada para inconsistências.
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public sealed void UpdateBalance()
        //Como esse método nunca foi sobreposto, dará erro ao adicionar sealed, pois ele não pode ser selado. Apenas métodos que já foram sobreposto como o override abaixo.
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        //Método selado impede que classes herdadas sopreponham esse método
        {
            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
