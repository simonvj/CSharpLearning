using MyLibrary;

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
        }
    }
}