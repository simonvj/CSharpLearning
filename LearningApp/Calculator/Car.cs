using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public abstract class Car // : ICar can implement an interface in the base class 
    {
        public Car(string make, string model, int year, Color color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        public virtual void Start()
        {
            Console.WriteLine("Roar");
        }
        // abstract methods must be defined in instance when using this base class
        public abstract void Accelerator(double pressure);
        public abstract void Brake(double pressure);
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public Color Color { get; set; }
    }
}
