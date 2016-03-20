namespace _01.StudentClass
{
    using _01.StudentClass.Optionals;
    using System;
    public class Student :ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private ulong ssn;
        private string permAddress;
        private string mobilePhone;
        private string email;
        private int course;
        private University university;
        private Faculty faculty;
        private Specialty specialty;

        public Student()
        {

        }
        public Student(string fName, string mName, string lName, ulong ssn,
                       int course,string email,University uni,Faculty fac,Specialty spec)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = ssn;
            this.Course = course;
            this.Email = email;
            this.University = uni;
            this.Faculty = fac;
            this.Specialty = spec;
        }
        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.firstName = value;
            }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle name cannot be empty!");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be empty!");
                }
                this.lastName = value;
            }
        }

        public ulong SSN
        {
            get { return this.ssn; }

            private set
            {
                if (value < 0 || value == null)
                {
                    throw new ArgumentException("SSN field value cannot be less than zero or cannot be empty!");
                }
                this.ssn = value;
            }
        }
        public string PermAddress
        {
            get { return this.permAddress; }
            set
            {
                //if (string.IsNullOrEmpty(value))
                //{
                //    throw new ArgumentException("Address field cannot be emtpy!");
                //}
                this.permAddress = value;
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }

            set
            {
                //if (string.IsNullOrEmpty(value))
                //{
                //    throw new ArgumentException("MobilePhone field cannot be emtpy!");
                //}
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                //if (string.IsNullOrEmpty(value))
                //{
                //    throw new ArgumentException("E-mail field cannot be emtpy!");
                //}
                this.email = value;
            }
        }
        public int Course
        {
            get { return this.course; }
            set
            {
                this.course = value;
            }
        }

        public University University
        {
            get { return this.university; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Students University field cannot be empty!");
                }
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get { return this.faculty; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Students faculty field cannot be empty!");
                }
                this.faculty = value;
            }
        }
        public Specialty Specialty
        {
            get { return this.specialty; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Students specialty field cannot be empty!");
                }
                this.specialty = value;
            }
        }

        public override bool Equals(object obj)
        {
            var objAsStud = obj as Student;
            if (objAsStud == null)
            {
                return false;
            }
            if (this.FirstName != objAsStud.FirstName)
            {
                return false;
            }
            else if (this.MiddleName != objAsStud.MiddleName)
            {
                return false;
            }
            else if (this.LastName != objAsStud.LastName)
            {
                return false;
            }
            else if (this.SSN != objAsStud.SSN)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ SSN.GetHashCode();
        }

        public override string ToString()
        {
            return "Full name: " + this.FirstName + " " + this.MiddleName + " " + this.LastName + "\n" +
                "University: " + this.University + "\n" +
                "SSN: " + this.SSN + "\n" + 
                "Faculty: " + this.Faculty + "\n" + 
                "Specialty: " + this.Specialty;
        }

        public static bool operator ==(Student studentOne,Student studentTwo)
        {
            return Student.Equals(studentOne, studentTwo);
        }

        public static bool operator !=(Student studentOne,Student studentTwo)
        {
            return !(Student.Equals(studentOne, studentTwo));
        }

        public object Clone() //task 2 - Implement a deep copy of the Student
        {
            Student clonedStud = new Student();
            clonedStud.FirstName = this.FirstName;
            clonedStud.MiddleName = this.MiddleName;
            clonedStud.LastName = this.LastName;
            clonedStud.SSN = this.SSN;
            clonedStud.Specialty = this.Specialty;
            clonedStud.PermAddress = this.PermAddress;
            clonedStud.MobilePhone = this.MobilePhone;
            clonedStud.Email = this.Email;
            clonedStud.Course = this.Course;
            clonedStud.University = this.University;
            clonedStud.Faculty = this.Faculty;
            clonedStud.Specialty = this.Specialty;

            
            return clonedStud;
        }

        public int CompareTo(Student other) // task 3
        {
            if (this.FirstName.Length > other.FirstName.Length || this.MiddleName.Length > other.MiddleName.Length ||
                this.LastName.Length > other.LastName.Length)
            {
                return 1;
            }
            else if (this.FirstName.Length < other.FirstName.Length || this.MiddleName.Length < other.MiddleName.Length ||
                this.LastName.Length < other.LastName.Length)
            {
                return -1;
            }
            else if (this.FirstName.Length == other.FirstName.Length || this.MiddleName.Length == other.MiddleName.Length ||
                this.LastName.Length == other.LastName.Length)
            {

                for (int i = 0; i < this.FirstName.Length; i++)
                {
                    if (this.FirstName[i] > other.FirstName[i])
                    {
                        return 1;
                    }
                    else if (this.FirstName[i] < other.FirstName[i])
                    {
                        return -1;
                    }
                }
                for (int i = 0; i < this.MiddleName.Length; i++)
                {
                    if (this.MiddleName[i] > other.MiddleName[i])
                    {
                        return 1;
                    }
                    else if (this.MiddleName[i] < other.MiddleName[i])
                    {
                        return -1;
                    }
                }
                for (int i = 0; i < this.LastName.Length; i++)
                {
                    if (this.LastName[i] > other.LastName[i])
                    {
                        return 1;
                    }
                    else if (this.LastName[i] < other.LastName[i])
                    {
                        return -1;
                    }
                }
            }
            if (this.SSN == other.SSN)
            {
                return 0;
            }
            if (this.SSN < other.SSN)
            {
                return -1;
            }
            if (this.SSN > other.SSN)
            {
                return 1;
            }

            return 0;
        }
    }
}
