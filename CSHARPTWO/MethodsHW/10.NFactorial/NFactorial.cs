using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.NFactorial
{
    class NFactorial
    {
        //Write a program to calculate n! for each n in the range [1..100].
        
        static BigInteger CalculateFactorial(BigInteger value)
        {
            BigInteger temporalFactorial = 1;
            BigInteger factorial = 1;
            List<BigInteger> veryBigList = new List<BigInteger>();
            for (int i = 1; i < 101; i++)
			{
                  factorial = factorial * i;
                    veryBigList.Add(factorial);

                
			}
            for (int i = 1; i < value; i++)
            {
                temporalFactorial = temporalFactorial * i;
            }
            int index = veryBigList.IndexOf(temporalFactorial);
            BigInteger newValue = veryBigList[index];

            return newValue;
            
            
        }
        static void Main()
        {
            
            //int number = 100;
            //BigInteger factorial = 1;
            //for (int i = 1; i < number; i++)
            //{
            //    factorial = factorial * i;
            //}
            //Console.WriteLine("{0} {1}",number,factorial);
            Console.Write("Please enter number : ");
            BigInteger K = BigInteger.Parse(Console.ReadLine());
            BigInteger result = CalculateFactorial(K);
            Console.WriteLine("result: {0}",result);
            
        }
        
    }
}
