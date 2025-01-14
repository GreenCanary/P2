using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
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
            Console.WriteLine("Meows");
        }
    }
}
