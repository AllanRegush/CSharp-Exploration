using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesLibrary
{
    public class Animal : IRun
    {
        public void Running()
        {
            Console.WriteLine($"{this.GetType().Name} is Running");
        }
    }
}
