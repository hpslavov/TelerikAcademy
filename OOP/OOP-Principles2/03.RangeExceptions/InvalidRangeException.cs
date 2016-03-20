namespace _03.RangeExceptions
{
    using System;
    public class InvalidRangeException<T> : ArgumentOutOfRangeException
    {
        private T startRange;
        private T endRange;
        public InvalidRangeException(string msg):base(msg)
        {

        }

        public InvalidRangeException(string msg, T startRange, T endRange)
            : base(msg)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }

        public T StartRange
        {
            get { return this.startRange; }

            set
            {
                this.startRange = value;
            }
        }
        public T EndRange
        {
            get { return this.endRange; }
            set
            {
                this.endRange = value;
            }
        }

       



    }
}
