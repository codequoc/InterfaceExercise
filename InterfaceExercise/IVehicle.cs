using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int Wheels { get; set; }
        public int Accelerator { get; set; }
        public int numOfWindows { get; set; }
        public string Model { get; set; }

    }
}
