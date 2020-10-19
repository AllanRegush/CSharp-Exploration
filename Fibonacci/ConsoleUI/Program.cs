using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibonacciLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci.fib1(10));
            Console.WriteLine(Fibonacci.fib2(10));
            Console.WriteLine(Fibonacci.fib2(10));
            Console.ReadLine();
        }
    }
}
