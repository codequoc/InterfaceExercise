using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {
        public Truck() { }
        public bool hasBed { get; set; }
        public double weightCarry { get; set; }
        public int Wheels { get; set; } = 4;
        public int Accelerator { get; set; }
        public int numOfWindows { get; set; } = 4;
        public string Model { get; set; } = "Silverado";
        public string Name { get; set; } = "Chevrolet";
        public string Motto { get; set; }

    }
}
