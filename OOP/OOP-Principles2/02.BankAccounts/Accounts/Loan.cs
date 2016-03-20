namespace _02.BankAccounts.Accounts
{
    using _02.BankAccounts.Customers;
using _02.BankAccounts.Interfaces;
using System;
    public class Loan: Account, IDeposit
    {
        public Loan(Customer customer,decimal balance,decimal interestRate):base(customer,balance,interestRate)
        {

        }

        public void DepositAmount(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterest(int contractPeiord)
        {
            if (this.Customer is BusinessCustomer)
            {
                contractPeiord = contractPeiord - 2;
            }
            else if (this.Customer is IndividualCustomer)
            {
                contractPeiord = contractPeiord - 3;
            }
            else if (contractPeiord == 0)
            {
                return 0;
            }
            return this.InterestRate * contractPeiord;
        }
    }
}
