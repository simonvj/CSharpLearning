using System;
namespace MyLibrary
{
    public class Calculator
    {
        double sum;
        public Calculator(double initialValue)
        {
            sum = initialValue;
        }
        public Calculator() : this(0)
        {
        }
        // can change passed argument in method with ref keyword in front
        public double Add(double x)
        {
            return x;
        }
        public double GetSum()
        {
            return sum;
        }
        public double ComputePi(int numDevimalPlaces, out TimeSpan duration)
        {
            duration = TimeSpan.FromSeconds(20);
            return 3.14;
        }

    }
}