//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
//Dogs, frogs and cats are Animals.
//All animals can produce sound (specified by the ISound interface). 
//Kittens and tomcats are cats. All animals are described by age, name and sex.
//Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class AnimalCenter
    {
       
        static void Main()
        {

            var tomCats = new List<Tomcat>()
            {
                new Tomcat("Tomy",2),
                new Tomcat("Tomas",3),
                new Tomcat("Tomasssian",8),
                new Tomcat("Toma",4),
                new Tomcat("Tomati",7)
            };
            double averageTomy = Animal.CalculateAverageAge(tomCats);
            Console.WriteLine("Average age in TomCats: {0}",averageTomy);


            var frogs = new List<Frog>()
            {
                new Frog("Froggy",2,Gender.Female),
                new Frog("Froggurd",4,Gender.Male),
                new Frog("Frogstur",7,Gender.Male),
                new Frog("Froggarella",4,Gender.Female)
            };
            double averageFrogA = Animal.CalculateAverageAge(frogs);
            Console.WriteLine("Average age in Frogs:{0}",averageFrogA);

            var dogs = new List<Dog>()
            {
                new Dog("Johhny",2,Gender.Male),
                new Dog("Simo",4,Gender.Male),
                new Dog("Saimun",5,Gender.Female),
                new Dog("Lili",10,Gender.Female)
            };
            double averageDogA = Animal.CalculateAverageAge(dogs);
            Console.WriteLine("Average age in Dogs: {0}",averageDogA);


            var kittens = new List<Kitten>()
            {
                new Kitten("Kitty",5),
                new Kitten("Kittana",4),
                new Kitten("Kittassian",3),
                new Kitten("Kit",2)
            };
            double averageKittenAge = Animal.CalculateAverageAge(kittens);
            Console.WriteLine("Average age in Kittens: {0}",averageKittenAge);

            var cats = new List<Cat>()
            {
                new Cat("Jenifur",10,Gender.Female),
                new Cat("Jinjur",1,Gender.Female),
                new Cat("Jason",5,Gender.Male),


            };
            double averageAge = Animal.CalculateAverageAge(cats);
            Console.WriteLine("Average age in Cats:{0}",averageAge);
        }
    }
}
