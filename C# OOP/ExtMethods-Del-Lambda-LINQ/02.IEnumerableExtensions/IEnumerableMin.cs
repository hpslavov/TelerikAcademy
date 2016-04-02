namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class IEnumerableMin
    {
        // implement extension method Min<T> in IEnumerable<T>
        public static T Min<T>(this IEnumerable<T> collection)
        {
            T result = default(T);

            foreach (var item in collection)
            {
                if ((dynamic)item < result)
                {
                    result = (dynamic)item;
                }
            }
            return result;
        }
    }
}
