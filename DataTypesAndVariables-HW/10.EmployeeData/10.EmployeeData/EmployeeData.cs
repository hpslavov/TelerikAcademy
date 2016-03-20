using System;
class EmployeeData
{
    static void Main()
    {
        //Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
        //Use descriptive names. Print the data at the console.
        string firstName;
        string lastName;
        byte age;
        string gender;
        long personalID;
        long uniqueEnumber;
        Console.Write("Enter first name:");
        firstName = Console.ReadLine();
        Console.Write("Enter last name:");
        lastName = Console.ReadLine();
        Console.Write("Enter you age:");
        age = byte.Parse(Console.ReadLine());
        Console.Write("Enter you gender M/F:");
        gender = Console.ReadLine();
        Console.Write("Enter personal ID number:");
        personalID = long.Parse(Console.ReadLine());
        Console.Write("Enter unique employee number:");
        uniqueEnumber = long.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("DATA FOR EMPLOYEE");
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}",gender);
        Console.WriteLine("Personal ID: {0}",personalID);
        Console.WriteLine("Unique Employee Number: {0}",uniqueEnumber);
    }
}
