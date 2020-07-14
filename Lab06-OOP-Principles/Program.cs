using Lab06_OOP_Principles.Classes.Concrete;
using System;

namespace Lab06_OOP_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animals can Eat, Move, Sleep, and Make a Sound.\n");

            Console.WriteLine("\nCanines are Animals that can Sniff, Swim, and Mark Territory.\n");
            Console.WriteLine("\nDog inherits from Animal and Canine. See the dog do things:");
            Dog dog = new Dog();
            Console.WriteLine(dog.Eat());
            Console.WriteLine(dog.Sleep());
            Console.WriteLine(dog.Move());
            Console.WriteLine(dog.MakeSound());
            Console.WriteLine(dog.Sniff());
            Console.WriteLine(dog.Swim());
            Console.WriteLine(dog.MarkTerritory());

            Console.WriteLine("\nWolf inherits from Animal and Canine. See the wolf do things:");
            Wolf wolf = new Wolf();
            Console.WriteLine(wolf.Eat());
            Console.WriteLine(wolf.Sleep());
            Console.WriteLine(wolf.Move());
            Console.WriteLine(wolf.MakeSound());
            Console.WriteLine(wolf.Sniff());
            Console.WriteLine(wolf.Swim());
            Console.WriteLine(wolf.MarkTerritory());

            Console.WriteLine("\nFish are Animals that can Breathe Underwater and Find A School.\n");
            Console.WriteLine("\nShark inherits from Animal and Fish. See the shark do things:");
            Shark shark = new Shark();
            Console.WriteLine(shark.Eat());
            Console.WriteLine(shark.Sleep());
            Console.WriteLine(shark.Move());
            Console.WriteLine(shark.MakeSound());
            Console.WriteLine(shark.BreatheUnderwater());
            Console.WriteLine("Find a school? " + shark.FindASchool(false));

            Console.WriteLine("\nPachyderms are Animals that can Charge and Roll Around.\n");
            Console.WriteLine("\nRhino inherits from Animal and Pachyderm. See the rhino do things:");
            Rhino rhino = new Rhino();
            Console.WriteLine(rhino.Eat());
            Console.WriteLine(rhino.Sleep());
            Console.WriteLine(rhino.Move());
            Console.WriteLine(rhino.MakeSound());
            Console.WriteLine(rhino.Charge());
            Console.WriteLine(rhino.RollAround());

            Console.WriteLine("\nHippo inherits from Animal and Pachyderm. See the hippo do things:");
            Hippo hippo = new Hippo();
            Console.WriteLine(hippo.Eat());
            Console.WriteLine(hippo.Sleep());
            Console.WriteLine(hippo.Move());
            Console.WriteLine(hippo.MakeSound());
            Console.WriteLine(hippo.Charge());
            Console.WriteLine(hippo.RollAround());
        }
    }
}
