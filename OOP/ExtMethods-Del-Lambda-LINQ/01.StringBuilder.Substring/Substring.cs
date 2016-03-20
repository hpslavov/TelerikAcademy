namespace _01.StringBuilder.Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class Substring
    {
        public static StringBuilder SubString(this StringBuilder str,int index,int length)
        {
            string stringBuilder = str.ToString();
            StringBuilder result = new StringBuilder(length);

            if (index < 0 || length <= 0)
            {
                throw new ArgumentException("Index and length of Substring cannot be less than or equal to Zero");
            }
            int loopLength = index + length;

            for (int i = index; i < loopLength; i++)
            {
                result.Append(stringBuilder[i]);
            }

            return result;
        }
    }
}
