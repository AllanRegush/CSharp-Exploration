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
            for(int i = 1; i <= 100; ++i)
            {
                if(i == 73)
                {
                    throw new Exception("This is 73");
                }
            }
        }
    }
}
