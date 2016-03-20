//Define a class Student, which contains data about a student – 
//first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty.
//Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

namespace _01.StudentClass
{
    using _01.StudentClass.Optionals;
    using System;
    public class StudentClass
    {
        static void Main(string[] args)
        {
            Student peshoStud = new Student("Pesho", "Petrov", "Peshev", 9006036584, 1, "p@gmail.com", University.SofiaUniversity,
                Faculty.Physics, Specialty.Physics);
            Student ivanStud = new Student("Pesho", "Petrov", "Peshev", 9006036584, 1, "pa@gmail.com", University.SofiaUniversity,
                Faculty.Physics, Specialty.Physics);
            Console.WriteLine(peshoStud.CompareTo(ivanStud));

            Console.WriteLine(peshoStud.Equals(ivanStud));
            Console.WriteLine(peshoStud.GetHashCode());
            Console.WriteLine(ivanStud.GetHashCode());
            Console.WriteLine(peshoStud.ToString());
            Console.WriteLine(peshoStud == ivanStud);
            Console.WriteLine(peshoStud != ivanStud);

            var cloned = ivanStud.Clone() as Student;
            Console.WriteLine(ivanStud.SSN);
            Console.WriteLine(cloned.SSN);
            
        }
    }
}
