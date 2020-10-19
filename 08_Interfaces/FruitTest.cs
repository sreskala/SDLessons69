using System;
using _08_Interfaces.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Interfaces
{
    [TestClass]
    public class FruitTest
    {
        [TestMethod]
        public void OrangeTest()
        {
            Orange orange = new Orange(true);
            Orange unOrange = new Orange(false);

            Console.WriteLine(orange.Peel());
            Console.WriteLine(unOrange.Peel());

            string SmallerNum(string n1, string n2)
            {
                int result = String.Compare(n1, n2);

                return result <= 0 ? n1 : n2;
            }

            Console.WriteLine(SmallerNum("21","56"));
        }
    }
}
