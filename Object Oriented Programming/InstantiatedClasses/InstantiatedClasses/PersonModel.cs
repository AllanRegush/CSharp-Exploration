using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public AddressModel Address { get; set; } = new AddressModel();
    }
}
