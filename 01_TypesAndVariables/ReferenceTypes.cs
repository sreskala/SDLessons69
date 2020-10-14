using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Sam";
            string lastName = "Reskala";

            string concatenatedName = firstName + " " + lastName;

            Console.WriteLine(concatenatedName);

            //compositing
            string compositeName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(compositeName);

            string interpolatedName = $"{firstName} {lastName}";

        }

        [TestMethod]
        public void Classes()
        {
        {
            Random randy = new Random();
            //randy is now object of Type Random

           int randNum = randy.Next(2, 109);
            Console.WriteLine(randNum);

        }

        [TestMethod]
        public void Collections()
        {
            string stringEx = "Hello World!";

            string[] stringArr = { "Yo", "Ok", "Here", "we", stringEx };

            string thirdIt = stringArr[2];

            Console.WriteLine(thirdIt);

            List<string> listofStrings = new List<string>();
            listofStrings.Add("hELLO");

            Queue<string> firstInOut = new Queue<string>();
            firstInOut.Enqueue("I'm first bitches!");
            firstInOut.Enqueue("I'm next yo");
            string firstItem = firstInOut.Dequeue();

            Dictionary<string, string> keyAndValue = new Dictionary<string, string>();
            keyAndValue.Add("name", "Sam");

            string nameDic = keyAndValue["name"];

            //Others:
            //SortedList
            //HashSet
            //Stack
        }
    }
}
