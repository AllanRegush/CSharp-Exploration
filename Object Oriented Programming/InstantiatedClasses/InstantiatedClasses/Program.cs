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
            PersonModel person = new PersonModel();

            person.FirstName = "Bob";
            person.Address.Street = "Fake Street";

            Console.WriteLine($"Hello, {person.FirstName}! You live on {person.Address.Street}");

            Console.ReadLine();
        }
    }
}
