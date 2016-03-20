namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Class : Student
    {
        private string uniqueID;
        private List<Teacher> teachers;
        private List<Student> numberOfStudents;
        
        public Class()
        {

        }
        public Class(string uniqueID)
        {
            this.UniqueID = uniqueID;
        }
        
        public Class(string id,List<Student> numberOfStudents):this(id)
        {
            this.NumberOfStudents = new List<Student>();
           
        }

        public List<Student> NumberOfStudents
        {
            get { return this.numberOfStudents; }
            set
            {
                this.numberOfStudents = value;
            }
        }
        public string UniqueID
        {
            get { return this.uniqueID; }

            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Unique ID of class cannot be empty");
                }
                this.uniqueID = value;
            }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }

            set
            {
                this.teachers = value;
            }
        }

        public void AddStudent(Student name)
        {
            this.NumberOfStudents.Add(name);
        }
       
    }
}
