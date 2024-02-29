using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class M3 : ICar
    {
        public string Make => "BMW";

        public string Model => "M3";

        public int Year => 2020;
        public Color Color { get; set; }

        public void Accelerator(double pressure)
        {
            Console.WriteLine("Vroom");
        }

        public void Brake(double pressure)
        {
            Console.WriteLine("IIIIhhhhh");
        }

        public void Start()
        {
            Console.WriteLine("WRRmmmm!");
        }
    }
}
