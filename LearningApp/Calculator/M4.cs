using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class M4 : Car
    {
        public M4() : base("BMW", "M4", 2008, Color.AliceBlue)
        {
            
        }
        public override void Accelerator(double pressure)
        {
            Console.WriteLine("Driving");
        }
        public override void Brake(double pressure)
        {
            Console.WriteLine("Stopped");
        }

    }
}
