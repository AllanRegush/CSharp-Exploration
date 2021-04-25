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
            "Hello Console".WriteToConsole();

            var person = new Person();
            person.SetName("Bob").SetDefaultAge().PrintInfo();

            var personA = new Person();
            personA.PrintInfo();

            Console.ReadLine();
        }
    }
}
