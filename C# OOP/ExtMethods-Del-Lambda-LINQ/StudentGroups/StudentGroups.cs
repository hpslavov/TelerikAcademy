using _09.StudentGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public class StudentGroups
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            Student peshoStudent = new Student("Pesho", "Ivanov", "p.i@abv.bg", new List<int> { 2, 4, 6 }, 2, "02766196");
            Student ivanStudent = new Student("Ivan", "Ivanov", "i.p@abv.bg", new List<int> { 2, 4, 6 }, 3, "02900659");
            Student icoStudent = new Student("Ico", "Petrov", "i.ppp@gmail.com", new List<int> { 3, 4, 5 }, 6, "082912634520");
            Student naskoStudent = new Student("Nasko", "Ilien", "n.ppp@gmail.com", new List<int> { 2, 4, 6 }, 6, "0249128520");
            Student petqStudent = new Student("Petq", "Slavova", "petya@abv.com", new List<int> { 6, 4, 6 }, 2, "0241123");
            students.Add(peshoStudent);
            students.Add(ivanStudent);
            students.Add(icoStudent);
            students.Add(naskoStudent);
            students.Add(petqStudent);

            List<Group> groups = new List<Group>()
            {
                new Group(4,"Biomechanic"),
            new Group (5,"Mathemathical")
            };


            //task 9 with LINQ
            var filtered =
                from stud in students
                where stud.GroupNumber == 2
                select stud;

            foreach (var stud in filtered)
            {
                Console.WriteLine("Name:{0} GroupNumber:{1}", stud.FirstName, stud.GroupNumber);
            }
            //task 10

            var filteredOne = students.OrderBy(x => x.GroupNumber == 2);
            Console.WriteLine();
            foreach (var stud in filteredOne)
            {
                Console.WriteLine("Name:{0} GroupNumber:{1}", stud.FirstName, stud.GroupNumber);
            }

            var orderbyfirstname = students.OrderBy(s => s.FirstName);
            foreach (var item in orderbyfirstname)
            {
                Console.WriteLine("{0}", item.FirstName);
            }
        }
        //task11

        public static void SortByEmail(IEnumerable<Student> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.Email.Contains("abv.bg")
                select st;

            Console.WriteLine("Students with email in ABV.BG");

            PrintStudents(sorted);
        }

        //task 12

        public static void SortByPhoneInSofia(IEnumerable<Student> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.Telefone.StartsWith("02")
                select st;

            Console.WriteLine("Students with phone numbers in Sofia");

            PrintStudents(sorted);
        }
        //task 13   
        public static void SortByExcelentMark(IEnumerable<Student> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.Marks.Contains(6)
                select new { FullName = st.ToString(), Marks = st.Marks };

            Console.WriteLine("Students  sorted by atleast one 6 mark");

            foreach (var student in sorted)
            {
                Console.WriteLine(student.FullName + "[" + string.Join(", ", student.Marks) + "]");
            }
            Console.WriteLine();
        }

        //task 14

        public static void SortByTwoMarks(IEnumerable<Student> students)
        {
            var filtered = ExtensionMethods.ExSortByTwoMarks(students);

            foreach (var item in filtered)
            {
                Console.WriteLine();
            }
        }
        public static void PrintStudents(IEnumerable<Student> studentsGroup)
        {
            foreach (Student student in studentsGroup)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
        }



        //problem 15
        public static void SortBySigningIn2006(IEnumerable<Student> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.FN.EndsWith("06")
                select st;

            Console.WriteLine("Marks of students enrolled in 2006");

            foreach (Student student in sorted)
            {
                Console.WriteLine(student.ToString() +
                    "[" + string.Join(", ", student.Marks) + "]");
            }
            Console.WriteLine();
        }
    }

  }


  


