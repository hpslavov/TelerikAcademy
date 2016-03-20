using System;
    class StringsAndObjectives
    {
        static void Main()
        {
            //Declare two string variables and assign them with Hello and World.
            //Declare an object variable and assign it with the concatenation of the first two variables
            //(mind adding an interval between).
            //Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
            string stringVariable = "Hello";
            string anotherString = "World!";
            object objectVariable = stringVariable + " " +  anotherString;
            string newString = (string)objectVariable;
            Console.WriteLine(newString);
        }
    }
