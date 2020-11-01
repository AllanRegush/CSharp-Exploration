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
            List<string> members = new List<string>();
            string prompt;
            do
            {
                Console.WriteLine("Enter Member's first name");
                string memberFirstName = Console.ReadLine();
                members.Add(memberFirstName);
                Console.WriteLine("Is there more members? Y/N");
                prompt = Console.ReadLine();
            } while (prompt.ToLower() == "y" || prompt.ToLower() == "yes");

            Console.WriteLine($"Total Members: { members.Count } ");

            Console.ReadLine();
        }
    }
}
