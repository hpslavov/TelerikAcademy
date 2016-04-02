namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Teacher,IPerson
    {
        private int uniqueClassNumber;

        public Student()
        {

        }
        public Student(string name, int id)
        {
            this.Name = name;
            this.UniqueClassNumber = id;
        }


        public string Name { get; private set; }
        

        public int UniqueClassNumber
        {
            get { return this.uniqueClassNumber; }

            private set
            {
                if (value < 0 || value == 0)
                {
                    throw new ArgumentNullException("Invalid student number!");
                }
                this.uniqueClassNumber = value;
            }
        }

        
    }
}
