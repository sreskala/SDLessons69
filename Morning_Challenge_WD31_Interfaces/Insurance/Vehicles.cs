using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Challenge_WD31_Interfaces.Insurance
{
    public class Sedan : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public string Start()
        {
            return $"{Make} has started.";
        }

        public string Off()
        {
            return $"{Make} has been turned off.";
        }

        public string Drive()
        {
            return $"Driving {Make}.";
        }
    }

}
