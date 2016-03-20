namespace _18.GroupGrouping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GroupGrouping
    {
        static void Main(string[] args)
        {

            var students = new List<Student>()
            {
                new Student("Pesho","Biomechanic"),
                new Student("Adelina","Mathematical"),
                new Student("Sashko","Drawing"),
                new Student("Ilian","Drawing"),
                new Student("Ivcho","Mathemathical")


            };


            var sorted = Methods.GroupingGroups(students);

            foreach (var stud in sorted)
            {
                Console.WriteLine(stud.ToString());
            }
        }
    }
}
