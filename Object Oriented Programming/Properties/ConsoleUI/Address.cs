using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Address
    {
        public String StreetAddress { get; set; }
        public String City { get; set; }
        public String Province { get; set; }
        public String PostalCode { get; set; }

        public string FullAddress
        {
            get
            {
                return $"{StreetAddress} {City} {Province} {PostalCode}";
            }
        }

        public Address(string streetAddress, string city, string province, string postalCode)
        {
            StreetAddress = streetAddress;
            City = city;
            Province = province;
            PostalCode = postalCode;

        }
    }
}
