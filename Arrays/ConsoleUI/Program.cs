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
            string[] names = new string[] { "Bill", "Joe", "Jon" };
            Console.WriteLine("Please select a number from 1 to 3");
            string nameSelectText = Console.ReadLine();
            bool isNumberValid = int.TryParse(nameSelectText, out int selectedNamesIndex);
            while (isNumberValid == false || selectedNamesIndex > 3 || selectedNamesIndex < 1)
            {
                Console.WriteLine("That is a invaild number please try again");
                nameSelectText = Console.ReadLine();
                isNumberValid = int.TryParse(nameSelectText, out selectedNamesIndex);
            }
            Console.WriteLine($"You have selected { names[selectedNamesIndex - 1] }");

            Console.ReadLine();
        }
    }
}
