using System;
using System.Collections.Generic;

namespace AnimalHierarchy
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Animal: {Name}, Age: {Age}");
        }
        public virtual void Voice()
        {
            Console.WriteLine("Moo");
        }
    }
    public class Dog : Animal
    {
        private string Nickname { get; set; }
        public Dog(string name, int age, string nickname)
            : base(name, age)
        {
            Nickname = nickname;
        }
        public override void Show()
        {
            Console.WriteLine($"Dog: {Name}, Age: {Age}, Nickname: {Nickname}");
        }
        public override void Voice()
        {
            Console.WriteLine("Bark");
        }
    }
    public class Cat : Animal
    {
        private string Color { get; set; }

        public Cat(string name, int age, string color)
            : base(name, age)
        {
            Color = color;
        }

        public override void Show()
        {
            Console.WriteLine($"Cat: {Name}, Age: {Age}, Color: {Color}");
        }

        public override void Voice()
        {
            Console.WriteLine("Meow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Console.Title = "Animal Kingdom";
            Console.BackgroundColor = ConsoleColor.DarkRed; 
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Welcome to my animal kingdom!");
            Console.WriteLine("");

            var animals = new List<Animal>
            {
                new Animal("Cow", 5),
                new Dog("Dog", 3, "Barry"),
                new Cat("Cat", 2, "Red")
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(n+": ");
                animal.Show();
                animal.Voice();
                Console.WriteLine();
                n++;
            }
            Console.WriteLine("Made by Ivanov M.V.");
            Console.WriteLine("22/25 IS");
            Console.WriteLine(DateTime.Now);
        }
    }
}
