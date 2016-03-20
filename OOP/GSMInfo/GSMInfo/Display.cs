namespace GSMInfo
{
    using System;

    public class Display
    {
        private int size;
        private int colors;

        public Display()
        {
            this.Size = size;
            this.Colors = colors;
        }
        
        public Display(int size,int colors): this()
        {

        }
        
        public int Size
        {
            get { return this.size; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid size(must be larger than 0)");
                }
                this.size = value;

            }
        }
        public int Colors
        {
            get { return this.colors; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Display colors cannot be less than zero");
                }
                this.colors = value;
            }
        }
    }
}
