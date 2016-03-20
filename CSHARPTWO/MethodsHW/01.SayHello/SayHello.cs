using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SayHello
{
    class SayHello
    {
        static void Hello()
        {
            Console.Write("Please, enter you name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!",name);
        }
        static void Main()
        {
            Hello();
        }
    }
}
