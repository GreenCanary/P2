using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
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
            Console.WriteLine("Barks");
        }
    }
}
