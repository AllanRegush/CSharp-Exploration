using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressModel address = new AddressModel();
            address.StreetAddress = "123 Fake Street";
            Console.WriteLine(address.StreetAddress);
            Console.ReadLine();
        }
    }
}
