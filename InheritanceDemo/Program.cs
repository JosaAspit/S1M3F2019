using System;

namespace InheritanceDemo
{
    public class Animal
    {
        public int Legs { get; set; }
        public string Color { get; set; }
        public string Race { get; set; }
        public string Noise { get; set; }

        public void MakeNoise()
        {
            Console.WriteLine(Noise);
        }
    }

    public class Cat : Animal
    {
    }

    public class Dog : Animal
    {
    }

    public class Giraffe : Animal
    {
        public void NeckCombat()
        {
            Console.WriteLine("The giraffe hits you with its long neck");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat() { Legs = 10, Noise = "Mew" };
            Dog d = new Dog() { Legs = 4 , Noise = "Bark", Color = "Brown", Race = "German Shepard"};
            Giraffe g = new Giraffe { Legs = 4, Noise = "uhehuehah", Race = "African Steppe Giraffe", Color = "Brown and Yellow" };

            c.MakeNoise();

            d.MakeNoise();

            g.MakeNoise();
            g.NeckCombat();
            g.KillAnimal();

            Console.ReadKey();
        }
    }
}
