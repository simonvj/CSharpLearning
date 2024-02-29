using MyLibrary;

// after C#9 top-level statements are used: the namespace, class and main method are implicit so in principle not neccesarry

namespace LearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Calculator calc = new Calculator();

            TimeSpan foo;
            double pi = calc.ComputePi(1000, out foo);

            Console.WriteLine("{0} was computed in {1} seconds", pi, foo.TotalSeconds);

            Console.WriteLine("Numbers add to {0}", calc.AddNumbers(1, 2, 3, 4.4, 6.38));

            Console.WriteLine(Calculator.UsageCount); // way to call static methods that is true across all instances of the class

            Console.WriteLine(Calculator.Multiply(4.22,7.22));
        }
    }
}