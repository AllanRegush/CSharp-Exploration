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
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string ageText = Console.ReadLine();
            bool isValidAge = int.TryParse(ageText, out int age);
            while(isValidAge == false)
            {
                Console.WriteLine("That was an invaild age try again");
                ageText = Console.ReadLine();
                isValidAge = int.TryParse(ageText, out age);
            }

            if (name.ToLower() == "Bob" || name.ToLower() == "Sue")
            {
                Console.WriteLine("Welcome to your establishment");
            } 
            else if (age < 18)
            {
                Console.WriteLine($"You must wait { 18 - age } years to get in the club");
            }
            else
            {
                Console.WriteLine($"Welcome to the club {name}");
            }

            Console.ReadLine();

        }
    }
}
