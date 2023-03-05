using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Sobreposicao.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(double loanLimit, int number, string holder, double balance) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Load(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
