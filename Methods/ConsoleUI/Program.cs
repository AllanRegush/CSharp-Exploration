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
            int age = getAge();
            logUserAge(age);
            Console.ReadLine();
        }

        private static int getAge()
        {
            Console.WriteLine("What is your age?");
            string ageText = Console.ReadLine();
            bool isValidAge = int.TryParse(ageText, out int age);
            if (isValidAge == false)
            {
                Console.WriteLine("That was not a valid age. Try again.");
                ageText = Console.ReadLine();
                isValidAge = int.TryParse(ageText, out age);
            }

            return age;
        }

        private static void logUserAge(int age)
        {
            Console.WriteLine($"Your age is { age }");
        }
    }
}
