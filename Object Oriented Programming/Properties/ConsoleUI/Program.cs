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
            Address address = new Address("123 Fake Street", "Fake Town", "Fake Province", "1Z4191");

            Console.WriteLine(address.FullAddress);

            Console.ReadLine();
        }
    }
}
