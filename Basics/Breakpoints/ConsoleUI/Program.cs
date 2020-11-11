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
            int total = 0;
            for (int i = 0; i < 20; i++)
            {
                total += i * 8;
            }
        }
    }
}
