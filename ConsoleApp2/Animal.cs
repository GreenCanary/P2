using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
    }

