namespace _02.BankAccounts.Accounts
{
    using _02.BankAccounts.Customers;
using System;
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer,decimal balannce,decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balannce;
            this.InterestRate = interestRate;
        }
        public Customer Customer
        {
            get { return this.customer; }

            private set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get { return this.balance; }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be less than zero!");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }

            private set
            {
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int contractPeiord)
        {
            if (contractPeiord < 0 )
            {
                throw new ArgumentException("Contract period cannot be negative!");
            }
            return contractPeiord * this.InterestRate;
        }
    }
}
