namespace _02.BankAccounts.Accounts
{
    using _02.BankAccounts.Customers;
    using _02.BankAccounts.Interfaces;
    using System;
    public class Mortgage : Account, IDeposit
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
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
                if (contractPeiord < 12)
                {
                    return (decimal)base.CalculateInterest(contractPeiord) / (decimal)2;
                }
                else
                {
                    decimal temp = (decimal)base.CalculateInterest(contractPeiord) / (decimal)2;
                }

            }
            else if (this.Customer is IndividualCustomer)
            {
                contractPeiord = contractPeiord - 3;
            }
            return base.CalculateInterest(contractPeiord);
        }
    }
}
