//Write a method that from a given array of students finds all students whose first name is before 
//its last name alphabetically.
//Use LINQ query operators. - Task 3

//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. - Task 4

//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//Rewrite the same with LINQ. - Task 5
namespace _03.FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FirstBeforeLast
    {
        static void Main()
        {
            
            Student firstStudent = new Student("Ivan","Ivanev",19);
            Student secondStudent = new Student("Pesho", "Todorov",22);
            Student thirdStudent = new Student("Mariika", "Georgieva",26);
            Student fourthStudent = new Student("Dobromira", "Petrova",28);
            Student fifthStudent = new Student("Elena", "Krasimirova", 20);
            Student sixthStudent = new Student("Dimitrichka", "Alenska", 31);


            List<Student> studentCollection = new List<Student>();
            studentCollection.Add(firstStudent);
            studentCollection.Add(secondStudent);
            studentCollection.Add(thirdStudent);
            studentCollection.Add(fourthStudent);
            studentCollection.Add(fifthStudent);
            studentCollection.Add(sixthStudent);


            //task 3
            var filteredStudentst =
                from stud in studentCollection
                where  stud.FirstName.ToLower().CompareTo(stud.LastName) == -1
                select stud;

            foreach (var item in filteredStudentst)
            {
                Console.WriteLine(item.FirstName + " ");
            }//end of task 3
            Console.WriteLine();


            //task 4
            var filterAgeRange =
                from person in studentCollection
                where person.Age <= 24 && person.Age >= 18
                select person;

            foreach (var stud in filterAgeRange)
            {
                Console.WriteLine(stud.FirstName + " " + stud.LastName + " |Age:" + stud.Age);
            }
            //end of task 4

            Console.WriteLine();
            //task 5
            var nameDescending = studentCollection.OrderByDescending(s => s.FirstName).ThenByDescending(x => x.LastName);

            foreach (var stud in nameDescending)
            {
                Console.WriteLine("{0}", stud.FirstName);
            }
            Console.WriteLine();

            foreach (var stud in nameDescending)
            {
                Console.WriteLine("{0}", stud.LastName);
            }
            Console.WriteLine();

            var firstLastNameDescending =
                from stud in studentCollection
                orderby stud.FirstName descending, stud.LastName descending
                select stud;
            foreach (var stud in firstLastNameDescending)
            {
                Console.WriteLine("{0} {1,15}",stud.FirstName,stud.LastName);
            }
            //end of task 5
        }
    }
}
