namespace _03.AnimalHierarchy
{
    using System;
    public class Dog : Animal,ISound
    {
        public Dog(string name,int age,Gender sex):base(name,age,sex)
        {

        }
        public override void Sound()
        {
            Console.WriteLine("Bay bay!");
        }
    }
}
