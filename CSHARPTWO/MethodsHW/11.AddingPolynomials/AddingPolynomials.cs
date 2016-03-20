using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddingPolynomials
{
    //Write a method that adds two polynomials.
    //Represent them as arrays of their coefficients.
    //Example: x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

    class AddingPolynomials
    {
        private static void LengthRender(List<int> a,List<int>b)
        {
            int lengthMin = Math.Min(a.Count, b.Count);
            int lengthMax = Math.Max(a.Count,b.Count);
           
            if (lengthMax != lengthMin)
            {
                for (int i = lengthMin; i < lengthMax; i++)
                {
                    if (a.Count<b.Count)
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
        static List<int> AddingPolynoms(List<int> listOne,List<int> listTwo)
        {
            List<int> newList = new List<int>();
            int temp = 0;
            
            
            for (int i = 0; i < listOne.Count; i++)
            {
                temp = listOne[i] + listTwo[i];
                newList.Add(temp);
            }
            newList.Reverse();
            Console.WriteLine("x^0 = {0}, x^1 = {1}, x^2 = {2}",newList[0],newList[1],newList[2]);


            return newList;
        }
        static void Main()
        {
            List<int> arrayOne = new List<int> { 1, 5, 6 };
            List<int> arrayTwo = new List<int> { 1, 5 };
            LengthRender(arrayOne, arrayTwo);
            AddingPolynoms(arrayOne,arrayTwo);
            
        }
    }
}
