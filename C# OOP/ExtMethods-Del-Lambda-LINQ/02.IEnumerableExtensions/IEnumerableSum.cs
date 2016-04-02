namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class IEnumerableSum
    {
        //Implement sum extension method for IEnumerable<T>
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            T result = (dynamic)0;

            foreach (var item in collection)
            {
                result += (dynamic)item;
            }

            return result;


        }
    }
}
