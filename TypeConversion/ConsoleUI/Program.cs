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
            const int yearsSince2020 = 20;
            Console.WriteLine("What is your age?");
            string agetext = Console.ReadLine();
            bool isValidAge = int.TryParse(agetext, out int age);

            if (isValidAge)
            {
                age -= yearsSince2020; 
                if (age < 0)
                {
                    Console.WriteLine("You were not born in before 2000");
                }
                else
                {
                    Console.WriteLine($"You were { age } years old in 2000");
                }
            }
            else
            {
                Console.WriteLine("Please input a valid age");
            }

            Console.ReadLine();
        }
    }
}
