namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Kitten : Cat, ISound
    {
        private const Gender sex = Gender.Female;

        public Kitten(string name,int age):base(name,age)
        {

        }

        public Gender Sex { get { return Gender.Female; } }
        public override void Sound()
        {
            Console.WriteLine("I am KITTEN!!!");
        }
    }
}
