﻿//Create a class Person with two fields – name and age.
//Age can be left unspecified (may contain null value. 
//Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.
namespace _04.PersonClass
{
    using System;
    public class PersonTesting
    {
        public static void Main(string[] args)
        {
            Person pesho = new Person("Pesho");
            Console.WriteLine(pesho.ToString());
            pesho.Age = 15;
            Console.WriteLine(pesho.ToString());

        }
    }
}
