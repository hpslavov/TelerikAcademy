//We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher 
//teaches, a set of disciplines. Students have a name and unique class number. 
//Classes have unique text identifier. 
//Teachers have a name. Disciplines have a name, number of lectures and number of exercises.
//Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of OOP) and their 
//attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SchoolSystem
    {
        static void Main()
        {
            List<Teacher> teachers = new List<Teacher>();
            List<Discipline> ivanovs = new List<Discipline>();
            List<Discipline> mladenovs = new List<Discipline>();
            List<Discipline> disciplines = new List<Discipline>();

            
            Teacher Ivanov = new Teacher("Ivanov", ivanovs);
            Teacher Mladenov = new Teacher("Mladenov", mladenovs) ;

            

            Discipline literature = new Discipline("Literatura", 5, 4);
            Discipline mathemathics = new Discipline("Maths", 10, 15);
            Discipline biology = new Discipline("Biology", 17, 15);
            Discipline sports = new Discipline("Sports", 12, 15);
            Discipline chemistry = new Discipline("Chemistry", 27, 25);
            disciplines.Add(literature);
            disciplines.Add(mathemathics);
            disciplines.Add(biology);
            disciplines.Add(sports);
            disciplines.Add(chemistry);
            //Ivanov.DisciplineList();
            teachers.Add(Ivanov);
            teachers.Add(Mladenov);
            Class sedmiB = new Class("7B"); 
            sedmiB.Teachers = teachers;
            
            ivanovs.Add(literature);
            ivanovs.Add(sports);
            mladenovs.Add(chemistry);
            mladenovs.Add(biology);
            foreach (var teacher in sedmiB.Teachers)
            {
                Console.Write("{0} class are studyin with {1}: {2}",sedmiB.UniqueID,teacher.Name,string.Join(", ",teacher.Disciplines));
               // teacher.TellDiscipline();
                Console.WriteLine();
                

            }

            List<Student> sedmiBStudents = new List<Student>();
            Student pesho = new Student("Pesho", 27);
            Student gosho = new Student("Gosho", 5);
            Student petrana = new Student("Petrana", 17);
            sedmiBStudents.Add(pesho);
            sedmiBStudents.Add(gosho);
            sedmiBStudents.Add(petrana);
            
            sedmiB.NumberOfStudents = sedmiBStudents;
            Console.WriteLine(sedmiB.NumberOfStudents.Count);
            sedmiB.Teachers = teachers;


        }
    }
}
