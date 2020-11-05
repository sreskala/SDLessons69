using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Morning_Challenge_WD31_Interfaces.Insurance;

namespace Morning_Challenge_WD31_Interfaces
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IVehicle vehicle = new Sedan();
            vehicle.Make = "Toyota";
            vehicle.Model = "Hatch";
            vehicle.Color = "Grey";

            Console.WriteLine(vehicle.Start());
        }
    }
}
