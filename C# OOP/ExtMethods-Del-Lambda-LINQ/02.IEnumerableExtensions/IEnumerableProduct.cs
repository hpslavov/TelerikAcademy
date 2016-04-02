namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class IEnumerableProduct
    {
        // Implement extension method Product<T> for IEnumerable<T>
        public static T Product<T>(this IEnumerable<T> collection)
        {
            T result = (dynamic)1;

            foreach (T item in collection)
            {
                result *= (dynamic)item;
            }
            return result;
        }
    }
}
