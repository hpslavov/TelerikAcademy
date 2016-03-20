namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class IEnumerableAverage
    {
        public static T Average<T>(this IEnumerable<T> collection)
        {
            T result = default(T);
            int counter = 0;
            foreach (var item in collection)
            {
                result += (dynamic)item;
                counter++;
            }
            result = (dynamic)result / counter;
            return result;
        }
    }
}
