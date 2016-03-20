using System;
class Program
{
    static void Main()
    {
        //A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
        //bank name, IBAN, 3 credit card numbers associated with the account.
        string firstName;
        string middleName;
        string lastName;
        string holderName;
        decimal balance;
        string bankName;
        string iban;
        ulong firstCCardNumber;
        ulong secondCCardNumber;
        ulong thirdCCardNumber;
        Console.Write("Enter your first name: ");
        firstName = Console.ReadLine();
        Console.Write("Enter you middle name: ");
        middleName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        lastName = Console.ReadLine();
        Console.Write("Enter balance:");
        balance = decimal.Parse(Console.ReadLine());
        Console.Write("Enter bank name:");
        bankName = Console.ReadLine();
        //IBAN format : BG80 BNBG 9661 1020 3456 78
        Console.Write("Enter IBAN:");
        iban = Console.ReadLine();
        Console.Write("Enter first credit card number:");
        firstCCardNumber = ulong.Parse(Console.ReadLine());
        Console.Write("Enter second credit card number:");
        secondCCardNumber = ulong.Parse(Console.ReadLine());
        Console.Write("Enter third card number:");
        thirdCCardNumber = ulong.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("BANK ACCOUNT DATA");
        Console.WriteLine("Holder name: {0} {1} {2}",firstName,middleName,lastName);
        Console.WriteLine("Account balance: {0:C}",balance);
        Console.WriteLine("Bank name: {0}",bankName);
        Console.WriteLine("IBAN: {0}",iban);
        Console.WriteLine("First credit card ID: {0}",firstCCardNumber);
        Console.WriteLine("Second credit card ID: {0}",secondCCardNumber);
        Console.WriteLine("Third credit card ID: {0}",thirdCCardNumber);
    }
}
