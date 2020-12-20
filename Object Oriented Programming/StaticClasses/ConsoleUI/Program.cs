using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double addResult = CalculateData.Add(2, 3);
            double subResult = CalculateData.Subtract(1, 1);
            double multResult = CalculateData.Multiply(1, 2);
            double divideResult = CalculateData.Divide(1, 1);
            Console.WriteLine($"Add Result: {addResult}, Subtract Result: {subResult}");
            Console.WriteLine($"Multiply Result: {multResult}, DivideResult: {divideResult}");
            Console.ReadLine();
        }
    }
}
