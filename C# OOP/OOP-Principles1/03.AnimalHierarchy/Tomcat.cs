namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tomcat : Cat, ISound
    {
        private const Gender sex = Gender.Male;

        public Tomcat(string name,int age):base(name,age)
        {

        }


        public Gender Sex { get { return Gender.Male; } } 
        public override void Sound()
        {
            Console.WriteLine("I am TOMCAT!!!");
        }
    }
}
