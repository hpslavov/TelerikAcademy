namespace _03.AnimalHierarchy
{
    using System;
    public class Cat: Animal,ISound
    {
        public Cat()
        {

        }
        public Cat(string name,int age,Gender sex):base(name,age,sex)
        {

        }
        public Cat(string name,int age):base(name,age)
        {

        }
        public override void Sound()
        {
            Console.WriteLine("Miay miay!");
        }
    }
}
