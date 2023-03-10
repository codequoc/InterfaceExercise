using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public Car() { }
        public bool hasTrunk { get; set; }
        public int numOfPeople { get; set; } = 4;

        public int Wheels { get; set; } = 4;
        public int Accelerator { get; set; }
        public int numOfWindows { get; set; } = 6;
        public string Model { get; set; } = "Cmary";
        public string Name { get; set; } = "Toyota";
        public string Motto { get; set; }

    }
}
