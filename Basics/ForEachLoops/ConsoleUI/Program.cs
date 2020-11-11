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
            List<string> names = new List<string>();

            string conformation;
            do
            {
                Console.WriteLine("Enter the member's first name");
                string name = Console.ReadLine();
                names.Add(name);

                Console.WriteLine("Continue entering names? Y/N");
                conformation = Console.ReadLine().ToLower();
            } while (conformation == "y" || conformation == "yes");

            foreach (string name in names)
            {
                Console.WriteLine($"Hello, { name }");
            }

            Console.ReadLine();
        }
    }
}
