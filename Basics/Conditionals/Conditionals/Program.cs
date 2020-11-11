using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            //if (true)
            //{
            //    Console.Writeline("this code will run");
            //}
            //else
            //{
            //    Console.Writeline("this code will not run");
            //}

            //char letter = 'a';
            // in C# break is required
            //switch (letter)
            //{
            //    case 'a':
            //        Console.WriteLine($"{ letter }");
            //        break;
            //    case 'b':
            //        Console.WriteLine("This will not run");
            //        break;
            //    default:
            //        break;
            //}

            string name = Console.ReadLine();

            if (name.ToLower() == "bob")
            {
                Console.WriteLine("Hello Bob");
            }
            else
            {
                Console.WriteLine("You're not bob");
            }

            Console.ReadLine();
        }
    }
}
