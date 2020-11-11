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
            Console.WriteLine("Please enter a comma separated list of people ie. Jim,Frank,Joe");
            string[] listOfNames = Console.ReadLine().Split(',');

            for (int i = 0; i < listOfNames.Length; i++)
            {
                Console.WriteLine($"Hello, { listOfNames[i] }" );
            }

            Console.ReadLine();
        }
    }
}
