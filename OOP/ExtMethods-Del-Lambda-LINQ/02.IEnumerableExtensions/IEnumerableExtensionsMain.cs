//Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
//sum, product, min, max, average.
namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class IEnumerableExtensionsMain
    {

        static void Main()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            int average = list.Average<int>();
            Console.WriteLine(average);




        }
    }
}
