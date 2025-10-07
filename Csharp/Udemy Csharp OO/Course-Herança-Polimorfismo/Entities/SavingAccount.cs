using System;

namespace Course_Herança_Polimorfismo.Entities
{
    class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount(int number, string holder, double balance, double interestRate)
        : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void updateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}