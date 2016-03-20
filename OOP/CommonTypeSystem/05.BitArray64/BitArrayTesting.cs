//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
namespace _05.BitArray64
{
    using System;
    using System.Collections.Generic;
   

    public class BitArrayTesting
    {
        public static void Main(string[] args)
        {
            var num = new BitArray64();

            num[0] = 1;
            num[4] = 0;
            num[22] = 1;
            Console.WriteLine(num.ToString());
        }
    }
}
