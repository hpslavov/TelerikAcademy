using System;
using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            char c = '\u00A9';
            Console.WriteLine(@"
    {0}
   {0} {0}
  {0}   {0}
 {0} {0} {0} {0}", c);
        }
    }
