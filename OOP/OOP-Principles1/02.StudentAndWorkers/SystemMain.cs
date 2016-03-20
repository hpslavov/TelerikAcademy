//Define abstract class Human with a first name and a last name. 
//Define a new class Student which is derived from Human and has a new field – grade. 
//Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay 
//and a method MoneyPerHour() that returns money earned per hour by the worker.
//Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.
namespace _02.StudentAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SystemMain
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Pesho", "Peshev", 6),
                new Student("Mariiika","Iordanova",5),
                new Student("Mariq","Prodanova",5),
                new Student("Ilia","Marinkin",4),
                new Student("Cvetan","Kapitanski",4),
                new Student("Lili","Vladimirova",3),
                new Student("Geri","Georgieva",8),
                new Student("Pepi","Slabakov",12),
                new Student("Bobi","Marinkin",12),
                new Student("Slavi","Binev",1),

            };

            var gradeSorted = students.OrderBy(g => g.Grade);
                
            foreach (var item in gradeSorted)
            {
                Console.WriteLine("FirstName:{0}, Grade:{1}",item.FirstName,item.Grade);
            }


            var workers = new List<Worker>()
            {
                new Worker("Pesho","Peshev",150,12),
                new Worker("Cveti","Iordanova",190,10),
                new Worker("Adi","Petrova",130,8),
                new Worker("Bibi","Slavova",150,4),
                new Worker("Krasi","Ilieva",380,17),
                new Worker("Milena","Milenova",130,16),
                new Worker("Svetla","Danailova",700,14),
                new Worker("Ioana","Fileva",180,9),
                new Worker("Denica","Pesheva",150,12),
                new Worker("Petrana","Metute",150,12),

            };

            var moneySorted =
                workers.OrderByDescending(w => w.MoneyPerHour());
            Console.WriteLine();
            foreach (var worker in moneySorted)
            {
                Console.WriteLine("Lastname:{0}, MoneyPerHour:{1}",worker.LastName,worker.MoneyPerHour());
            }

            var mergedList = gradeSorted
                .Concat<Human>(moneySorted)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);
            Console.WriteLine();
            foreach (var item in mergedList)
            {
                Console.WriteLine(item.FirstName +" "+ item.LastName);
            }
        }
    }
}
