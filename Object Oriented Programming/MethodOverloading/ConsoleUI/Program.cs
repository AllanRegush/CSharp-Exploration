using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    partial class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            PersonModel person2 = new PersonModel("Bob", "Appleseed", 74);

            Console.WriteLine(person2.LastName);
            Console.ReadLine();
        }
    }
}
