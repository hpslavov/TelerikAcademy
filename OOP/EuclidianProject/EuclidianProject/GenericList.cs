namespace EuclidianProject
{
    using System;
    using System.Collections;
    using System.Text;
    [VersionAttribute("2","5")]
    public class GenericList<T>  where T: IComparable
    {
        private T[] elements;
        private int index;

        public GenericList(int capacity)//task 5
        {
            this.elements = new T[capacity];
            this.index = 0;
        }

        //task 5
        public void Add(T element)
        {
           
            this.elements[this.index] = element;
            this.index++;
            //task 6
            if (this.index == this.elements.Length)
            {
                T[] newElements = new T[this.elements.Length * 2];
                Array.Copy(this.elements, newElements, this.elements.Length);
                this.elements = newElements;
            }
        }

        public void RemoveAt(int index)
        {

            if (this.index < 0 || this.index >= this.elements.Length)
            {
                throw new IndexOutOfRangeException();
            }
            T[] newElements = new T[this.elements.Length - 1];
            //T removedElement = this.elements[index];


            for (int i = 0; i < index; i++)
            {
                newElements[i] = this.elements[i];
            }
            for (int i = index + 1; i < this.elements.Length - 1; i++)
            {
                newElements[i - 1] = this.elements[i];
            }
            for (int i = index; i < newElements.Length - 1; i++)
            {
                this.elements[i] = newElements[i];
            }

        }//task 5

        public void InsertAt(T number, int index)
        {
            if (this.index < 0 || this.index >= this.elements.Length)
            {
                throw new IndexOutOfRangeException();
            }
            T[] newElements = new T[this.elements.Length + 1];

            for (int i = 0; i < index; i++)
            {
                newElements[i] = this.elements[i];
            }
            newElements[index] = number;
            for (int i = index; i < this.elements.Length - 1; i++)
            {
                newElements[i + 1] = this.elements[i];
            }
            for (int i = 0; i < newElements.Length - 1; i++)
            {
                this.elements[i] = newElements[i];
            }

        }//task 5

        public void Clear()
        {
            T[] newElements = new T[this.elements.Length - 1];
            for (int i = 0; i < newElements.Length - 1; i++)
            {
                this.elements[i] = newElements[i];
            }
        }//task 5

        public int IndexOf(T element)
        {
            var index = 0;

            for (int i = 0; i < this.elements.Length - 1; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }//task 5

        public override string ToString()//task 5
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.index; i++)
            {
                sb.Append(this.elements[i]);
                if (i < this.index - 1)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }

        public T this[int index]
        {
            get
            {
                return elements[index];
            }
            set
            {
                if (index < 0 || index >= this.elements.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                this.elements[index] = value;
            }
        }//task 5

        public T Min()
        {
            T element = this.elements[0];

            for (int i = 0; i < this.elements.Length; i++)
            {
                if (element.CompareTo(this.elements[i]) > 0)
                {
                    element = this.elements[i];
                }
            }
            return element;
            
        } //task 7

        public T Max()
        {
            T element = this.elements[0];

            for (int i = 0; i < this.elements.Length; i++)
            {
                if (element.CompareTo(this.elements[i]) < 0)
                {
                    element = this.elements[i];
                }
            }
            return element;
        } // task 7

    }
}
