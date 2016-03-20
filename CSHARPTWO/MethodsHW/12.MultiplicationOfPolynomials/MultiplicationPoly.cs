using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MultiplicationOfPolynomials
{
    class MultiplicationPoly
    {
        //Write a method that multiplicates two polynomials.
        //Represent them as arrays of their coefficients.
        //Example: x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
        private static void LengthRender(List<int> a, List<int> b)
        {
            int lengthMin = Math.Min(a.Count, b.Count);
            int lengthMax = Math.Max(a.Count, b.Count);

            if (lengthMax != lengthMin)
            {
                for (int i = lengthMin; i < lengthMax; i++)
                {
                    if (a.Count < b.Count)
                    {
                        a.Add(0);
                    }
                    else
                    {
                        b.Add(0);
                    }
                }
            }
        }
        static List<int> MultiplicationOfPolynoms(List<int> listOne, List<int> listTwo)
        {
            List<int> newList = new List<int>();
            int temp = 0;


            for (int i = 0; i < listOne.Count; i++)
            {
                temp = listOne[i] * listTwo[i];
                newList.Add(temp);
            }
            newList.Reverse();
            Console.WriteLine(string.Join(" ", newList));



            return newList;
        }
        static void Main()
        {
            List<int> arrayOne = new List<int> { 2, 6, 5 };
            List<int> arrayTwo = new List<int> { -5, 8, 6 };
            LengthRender(arrayOne, arrayTwo);
            MultiplicationOfPolynoms(arrayOne, arrayTwo);

        }
    }
}
