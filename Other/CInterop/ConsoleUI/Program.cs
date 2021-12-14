using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = ZigMath.add(1, 2);
            Console.WriteLine($"Result From Zig: {result}");
            Console.ReadLine();
        }
    }


}
