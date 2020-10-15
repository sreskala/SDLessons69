using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance.Animals
{
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public string Color { get; set; }

        public Dog()
        {
            Console.WriteLine("I am bark");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Woof!");
        }

        public override void SayFurColor()
        {
            Console.WriteLine("My fur is golden");
        }
    }
}
