using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
        public SUV() { }
        public bool hasFourWheelDrive { get; set; }
        public int numOfPassengers { get; set; }
        public int Wheels { get; set; } = 4;
        public int Accelerator { get; set; }
        public int numOfWindows { get; set; } = 6;  
        public string Model { get; set; } = "Explorer";
        public string Name { get; set; } = "Ford";
        public string Motto { get; set; }
    }
}
