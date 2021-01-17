using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesLibrary
{
    public abstract class Animal : IRun
    {
        public void Running()
        {
            Console.WriteLine("Running");
        }
    }
}
