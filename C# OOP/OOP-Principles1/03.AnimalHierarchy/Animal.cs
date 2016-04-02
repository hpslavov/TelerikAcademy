using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public abstract class Animal :ISound
    {
        private string name;
        private int age;
        private Gender sex;

        public Animal()
        {

        }

        public Animal(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Animal(string name,int age,Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.sex = sex;
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Age cannot be less or equal to zero");
                }
                this.age = value;
            }
        }

        public Gender Sex
        {
            get { return this.sex; }

            private set
            {
                this.sex = value;
            }
        }
        public abstract void Sound();

        public static double CalculateAverageAge(IEnumerable<Animal> collection)
        {
            int temp = 0;
            foreach (var animal in collection)
            {
                temp += animal.Age;
            }
            double result = (double)temp / (double)collection.Count();
            return result;
        }
    }
}
