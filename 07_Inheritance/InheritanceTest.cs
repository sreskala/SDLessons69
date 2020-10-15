using System;
using System.Collections.Generic;
using System.Linq;
using _07_Inheritance.Animals;
using _07_Inheritance.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Inheritance
{
    [TestClass]
    public class InheritanceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person me = new Person();

            me.FirstName = "Sam";
            me.LastName = "Reskala";
            Console.WriteLine(me.Name);

            Employee Dwight = new Employee(12324);
            Dwight.FirstName = "Dwight";
            Dwight.LastName = "Schrute";
        }

        [TestMethod]
        public void AnimalTest()
        {
            //Animal animal = new Animal();
            Sloth sloth = new Sloth();

            Console.WriteLine(sloth.IsSlow);
            sloth.Move();
            sloth.SayFurColor();

            List<int> list = new List<int>();
        }
    }
}
