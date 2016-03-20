namespace _02.StudentAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class Student : Human
    {
       private int grade;

       public Student(string firstName,string lastName,int grade):base(firstName,lastName)
       {
           this.Grade = grade;
           
       }
       
       public int Grade
        {
            get { return this.grade; }

           private set
            {
                if (value == 0 || value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Incorrect value for grade!");
                }
                this.grade = value;
            }
        }
    }
}
