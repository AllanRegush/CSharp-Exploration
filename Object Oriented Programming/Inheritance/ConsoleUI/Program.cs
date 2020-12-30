using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceLibrary;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle motorcycle = new MotorCycle();
            motorcycle.Motor = "Gas";
            Console.WriteLine(motorcycle.Motor);
            Console.ReadLine();
        }
    }
}
