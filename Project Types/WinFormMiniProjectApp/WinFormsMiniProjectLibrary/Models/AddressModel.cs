using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsMiniProjectLibrary.Models
{
    public class AddressModel
    {
        public string Street { get; set; }
        public string City { get; set; }

        public string DisplayFullAddressValue => $"{Street}, {City}";
    }
}
