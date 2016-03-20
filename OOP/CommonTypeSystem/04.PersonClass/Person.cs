namespace _04.PersonClass
{
    using System;
    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("Persons name cannot be empty!");
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return "Name: " + this.Name + "\n"
                    + "Age: not specified!";
            }
            return "Name: " + this.Name + "\n"
                + "Age: " + this.Age;

        }
    }
}
