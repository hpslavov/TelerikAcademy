namespace _05.BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;
        const int size = 64;
        public BitArray64()
        {

        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("Index out range exception!");
                }
                return (int)((this.number >> index) & 1);
            }
            set
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException("Index out of range!");
                }

                if (value == 1)
                {
                    this.number = this.number | ((ulong)1 << index);
                }
                else
                {
                    this.number = this.number & (~((ulong)1 << index));
                }
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                if (((this.number >> (63 - i)) & 1) == 1)
                {
                    result.Append(1);
                }
                else
                {
                    result.Append(0);
                }
            }
            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            var bit = obj as BitArray64;
            if (bit == null)
            {
                return false;
            }
            return this.number == bit.number;
        }

        public static bool operator ==(BitArray64 firstB, BitArray64 secondB)
        {
            return firstB.Equals(secondB);
        }
        public static bool operator !=(BitArray64 firstB, BitArray64 secondB)
        {
            return !firstB.Equals(secondB);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return this[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.number.GetHashCode();
        }


    }



}
