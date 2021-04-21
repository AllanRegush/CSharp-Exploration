using System;
using AccessModifiersLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            var bossAge = worker.AskAgeOfBoss();
            Console.WriteLine($"The Worked asked the boss for their age and it is {bossAge}");
            Console.ReadLine();
        }
    }
}
