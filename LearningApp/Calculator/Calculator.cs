using System;
namespace MyLibrary
{
    public class Calculator
    {
        double sum;
        public static int UsageCount { get; set; }
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
            ++UsageCount;
            return x;
        }

        public double AddNumbers(params double[] array)
        {
            ++UsageCount;
            foreach (double value in array)
                sum += value;
            return sum;
        }
        public double GetSum()
        {
            return sum;
        }
        // expression bodied method for more concise short methods.
        public double ComputePi(int numDevimalPlaces, out TimeSpan duration)
        {
            ++UsageCount;
            duration = TimeSpan.FromSeconds(20);
            return 3.14;
        }
        public static double Multiply(double x, double y) => x * y;

    }
}