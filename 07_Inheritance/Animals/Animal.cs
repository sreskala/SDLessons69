﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance.Animals
{
    public enum DietType { Herbivore=1, Omnivore, Carnivore}
    public abstract class Animal
    {
        public int NumberOfLegs { get; set; }
        public bool HasFur { get; set; }
        public DietType DietType { get; set; }
        public Animal()
        {
            Console.WriteLine("This is the animal constructor");
        }

        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }

        public virtual void SayFurColor()
        {
            Console.WriteLine("Don't know what the fur color is");
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("Noise unknown");
        }

        
        
    }
}
