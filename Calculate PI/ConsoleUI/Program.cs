using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatePILibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatePI cal = new CalculatePI();
            Console.WriteLine(cal.CalculatePi(100000));
            Console.ReadLine();
        }
    }
}
