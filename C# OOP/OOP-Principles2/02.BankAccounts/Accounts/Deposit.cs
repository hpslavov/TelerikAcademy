namespace _02.BankAccounts.Accounts
{
    using _02.BankAccounts.Customers;
using _02.BankAccounts.Interfaces;
using System;
    public class Deposit : Account, IWithdraw, IDeposit
    {
        public Deposit(Customer customer,decimal balance,decimal interestRate):base(customer,balance,interestRate)
        {

        }
        public override decimal CalculateInterest(int contractPeiord)
        {
            if (this.Balance < 0 || this.Balance < 0)
            {
                throw new ArgumentException("Due to insufficient amount you interest is 0");
            }
            return base.CalculateInterest(contractPeiord);
        }
        public void WithDrawAmount(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Insufficient funds!");
            }
            this.Balance -= amount;
        }

        public void DepositAmount(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
