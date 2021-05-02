using System;
using CalculatorLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Calculator.Add(1, 1);
            int y = Calculator.Subtract(x, 2);
            int z = Calculator.Multiply(x, x);
            int xx = Calculator.Divide(z, x);


            Console.WriteLine($"Result: { xx }");
            Console.ReadLine();
        }
    }
}
