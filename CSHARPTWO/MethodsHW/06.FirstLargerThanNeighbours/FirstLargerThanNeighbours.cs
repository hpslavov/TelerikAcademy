using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a method that returns the index of the first element in array 
//that is larger than its neighbours, or -1, if there’s no such element.


namespace _06.FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static int FirstLargerThanNeighbourNumbers(int[] array)
        {
            int result = 0;


            if (array[0] > array[1])
            {
                result = Array.IndexOf(array,array[0]);
            }

            else if (array[0]<array[1])
            {
                for (int i = 1; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        result = i;
                        break;
                    }
                    if (array[array.Length - 1] > array[array.Length - 2])
                    {
                        result = -1;
                    }
                    
                }
                
                
            }
            else
            {
                result = -1;
            }
           

            return result;

        }
        static void Main()
        {
            int[] numbers = { 0, 21, 11, 14, 15, 18, 28 };
            //If you want to test other with other arrays,please uncomment:
            // int[] numbers = {1,2,3,4,5,6,7,8};
            //int[] numbers = {8,6,3,3,1,5,35};
            int value = FirstLargerThanNeighbourNumbers(numbers);
            Console.WriteLine("Index :  [{0}]",value);//first value larger than neighbours

        }
    }
}
