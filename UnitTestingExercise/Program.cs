using System;

namespace UnitTestingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCalc = new Calculator();
            Console.WriteLine(newCalc.Add(48, 200, 3));
            Console.WriteLine(newCalc.Subtract(980, 460));
            Console.WriteLine(newCalc.Multiply(30, 2));
            Console.WriteLine(newCalc.Divide(50, 5));
        }
    }
}
