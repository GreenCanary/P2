using System;
using System.Collections.Generic;
using ConsoleApp2;
namespace AnimalHierarchy
{
    
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
