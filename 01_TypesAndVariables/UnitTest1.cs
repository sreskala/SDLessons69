using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';

            //CR = Carriage Return
            //LF = Line Feed
            char specialChar = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255; //any number between 0 and 255 (8 bits)
            sbyte signedByteExample = -128; //Can have negatives but only half as far as byte
            short shortExample = 32767; //short number
            int intMin = -2147483648; //largest negative integer you can have
            Int32 intMax = 2147483647; //Int32 is same as int
            long longExample = 9110878956713473; //random num but huge

        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.04235f;

            double doubleExample = 1.39084029384298349875398d;
            Console.WriteLine(doubleExample);

            decimal decimalExample = 1.2323423476238746283746283746283462384m;
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake, Croissant, Cookies, Scone, Danish, Muffin }

        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            Console.WriteLine(myPastry);
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;

            DateTime birthday = new DateTime(1995, 8, 2);

            TimeSpan age = today - birthday;
            Console.WriteLine(age);
        }
    }
}
