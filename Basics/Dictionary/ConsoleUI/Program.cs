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
            Dictionary<int, string> members = new Dictionary<int, string>
            {
                { 1, "Bob" },
                { 2, "Frank" },
                { 10000, "Sue" },
                { 10001, "James" }
            };

            Console.WriteLine("What is your member ID number?");
            string memberIDString = Console.ReadLine();
            bool isValidID = int.TryParse(memberIDString, out int id);
            while (isValidID == false)
            {
                Console.WriteLine("Invalid entry please try again");
                memberIDString = Console.ReadLine();
                isValidID = int.TryParse(memberIDString, out id);
            }
            if (members.ContainsKey(id))
            {
                Console.WriteLine($"Your name is {members[id]}");
            }
            else
            {
                Console.WriteLine("Sorry, your not in our club");
            }

            Console.ReadLine();
        }
    }
}
