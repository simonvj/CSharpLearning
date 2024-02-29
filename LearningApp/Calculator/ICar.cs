using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal interface ICar
    {
        void Start();
        void Accelerator(double pressure);
        void Brake(double pressure);
        string Make { get; }
        string Model { get; }
        int Year { get; }
        Color Color { get; }
    }
}
