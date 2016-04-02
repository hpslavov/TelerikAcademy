namespace _03.AnimalHierarchy
{
    using System;
    public class Frog : Animal,ISound
    {
        public Frog(string name,int age,Gender sex):base(name,age,sex)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Frog frog!");
        }
    }
}
