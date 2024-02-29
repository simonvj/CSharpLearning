using MyLibrary;
using System.Drawing;

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

            // initialize cars with color using shorthand syntax and interface
            ICar[] cars = { new M3 { Color = Color.Silver }, new M3 { Color = Color.SeaShell}, };
            foreach(ICar car in cars)
            {
                PrintICarInfo(car);
                car.Start();
                car.Accelerator(10);
                
            }

            // using class inheritance - tight coupling
            Car[] cars2 = { new M4 { Color = Color.Silver }, new M4 { Color = Color.SeaShell }, };
            foreach (Car car in cars2)
            {
                PrintCarInfo(car);
                car.Start();
                car.Accelerator(10);

            }

        }

        public static void PrintICarInfo(ICar car)
        {
            Console.WriteLine("Here is a {0} {1} {2} {3}", car.Color.Name, car.Year, car.Make, car.Model);
        }

        public static void PrintCarInfo(Car car)
        {
            Console.WriteLine("Here is a {0} {1} {2} {3}", car.Color.Name, car.Year, car.Make, car.Model);
        }

    }
}