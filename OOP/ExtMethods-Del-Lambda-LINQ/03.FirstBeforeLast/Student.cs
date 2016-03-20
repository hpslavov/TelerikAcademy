namespace _03.FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : IComparable
    {
        private string firstName;
        private string lastName;
        private int age;
        public Student(string firstName,string lastName,int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        
        public Student()
        {

        }

        public string FirstName
        {
            get { return this.firstName; }

            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Students first name cannot be empty!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Students last name cannot be empty!");
                    
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Students age cannot be less than zero!");
                }
                this.age = value;
            }

        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Student newStudent = obj as Student;
            if (newStudent != null)
                return this.FirstName.CompareTo(newStudent.FirstName);
            else
            {
                throw new ArgumentException("Object is not a student!");
            }
                
                
        }

    }
}
