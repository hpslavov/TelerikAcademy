namespace StudentGroups
{
    using _09.StudentGroups;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fN;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;
        private int mark;


        public Student()
        {

        }

        public Student(string firstName,string lastName,string email,List<int> marks,int groupNumber,string tel)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Telefone = tel;
            this.Marks = marks;
            
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

        public int GroupNumber
        {
            get { return this.groupNumber; }
            private set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("Students Group number cannot be empty or less than zero");
                }
                this.groupNumber = value;
            }
        }

        public string Email
        {
            get { return this.email; }

            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Students email cannot be empty!");
                }
                this.email = value;
            }
        }

        public string Telefone
        {
            get { return this.tel; }

            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Telefone number field cannot be empty!");
                }
                this.tel = value;
            }
        }

        public List<int> Marks
        {
            get { return this.marks; }

            set
            {
                this.marks = value;
                
            }
        }



        public string FN
        {
            get { return this.fN; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Students faculty number cannot be empty or null");
                }

                this.fN = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        public Group Group { get; private set; }
      
    }
}
