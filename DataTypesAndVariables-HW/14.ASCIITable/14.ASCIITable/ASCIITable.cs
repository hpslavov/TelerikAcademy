using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main()
    {
        //Print the whole ASCII table.
        for (int isymbol = 0; isymbol <= 255; isymbol++ )
        {
            Console.WriteLine("{0} = {1}", isymbol, (char)isymbol);
        }
    }
}
