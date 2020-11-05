using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Challenge_WD31_Interfaces.Insurance
{
    public interface IVehicle
    {
        //make
        string Make { get; set; }

        //model
        string Model { get; set; }

        //color
        string Color { get; set; }

        //start
        string Start();
        string Off();

        string Drive();
    }
}
