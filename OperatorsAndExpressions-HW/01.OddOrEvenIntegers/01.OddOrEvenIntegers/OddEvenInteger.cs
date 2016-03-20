using System;
    class Program
    {
        static void Main()
        {
            //Problem 01.Write an expression that checks if given integer is odd or even.
            int intVariable;
            Console.Write("Enter integer number: ");
            intVariable = int.Parse(Console.ReadLine());
            bool isOdd = true;
            bool isEven = false;
            if(intVariable % 2 == 0)
            {
                Console.WriteLine("Is {0} odd ? - {1}",intVariable,isEven);
            }
            else
            {
                Console.WriteLine("Is {0} odd ? - {1}",intVariable,isOdd);
            }
        }
    }
