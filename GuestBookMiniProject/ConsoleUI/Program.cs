using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        private static List<string> parties = new List<string>();
        private static int totalGuests = 0;
        static void Main(string[] args)
        {
            LoadGuests();

            DisplayGuests();

            Console.ReadLine();
        }

        private static string GetPartyName()
        {
            Console.WriteLine("What is the party name?");
            string partyName = Console.ReadLine();
            return partyName;
        }

        private static void LoadGuests()
        
        {
            string confirmation = "y";
            while (confirmation.ToLower() == "y" || confirmation.ToLower() == "yes" )
            {
                string partyName = GetPartyName();
                parties.Add(partyName);
                Console.WriteLine("How many in your Party?");
                string partyCountText = Console.ReadLine();
                bool isValidCount = int.TryParse(partyCountText, out int guestCount);
                while (isValidCount == false)
                {
                    Console.WriteLine("Invaild amount please try again");
                    partyCountText = Console.ReadLine();
                    isValidCount = int.TryParse(partyCountText, out guestCount);
                }
                totalGuests += guestCount;
                Console.WriteLine("Add more guests? Y/N");
                confirmation = Console.ReadLine();
            }
        }

        private static void DisplayGuests()
        {
            foreach (string party in parties)
            {
                Console.WriteLine($"{party}");
            }
            Console.WriteLine($"Total Guests {totalGuests}");
        }
    }
}
