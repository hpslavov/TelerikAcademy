//A bank holds different types of accounts for its customers:
//deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money.

//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months).
//In the common case its is calculated as follows: number_of_months * interest_rate.

//Loan accounts have no interest for the first 3 months if are held by individuals
//and for the first 2 months if are held by a company.

//Deposit accounts have no interest if their balance is positive and less than 1000.

//Mortgage accounts have ½ interest for the first 12 months for companies and 
//no interest for the first 6 months for individuals.
////Your task is to write a program to model the bank system by classes and interfaces.

//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation
//of the interest functionality through overridden methods.


namespace _02.BankAccounts
{
    using _02.BankAccounts.Accounts;
    using _02.BankAccounts.Customers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BankMain
    {
        static void Main()
        {
            var pesho = new IndividualCustomer("Pesho");
            var goshoOOD = new BusinessCustomer("GoshoOOD");
            var petrana = new BusinessCustomer("PetranaEOOD");
            var depositAcc = new Deposit(pesho, 5000, 6);
            Console.WriteLine("Pesho`s balance : {0}",depositAcc.Balance);
            depositAcc.DepositAmount(6000);
            Console.WriteLine("Pesho`s balance after deposit: {0}",depositAcc.Balance);
            Console.WriteLine("Pesho`s interest for 6 months: {0} %",depositAcc.CalculateInterest(6));
            depositAcc.WithDrawAmount(10900);
            Console.WriteLine("Pesho`s balance after withdraw : {0}",depositAcc.Balance);

            var mortgage = new Mortgage(goshoOOD, 15000, 4);
            Console.WriteLine("Gosho`s mortgage balance: {0}",mortgage.Balance);
            mortgage.DepositAmount(32500);
            Console.WriteLine("Gosho`s mortgage balance after deposit: {0} ",mortgage.Balance);
            Console.WriteLine("Gosho`s mortgage interest : {0} %",mortgage.CalculateInterest(12));

            var loanAcc = new Loan(petrana, 73000, 2);
            Console.WriteLine("Petrana`s balance : {0}",loanAcc.Balance);
            Console.WriteLine("Petrana`s interest for 16 months : {0} %",loanAcc.CalculateInterest(16));
            loanAcc.DepositAmount(50000);
            Console.WriteLine("Petrana`s balance after deposit : {0}",loanAcc.Balance);

        }
    }
}
