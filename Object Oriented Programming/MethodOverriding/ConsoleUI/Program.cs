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
            var thing = new Thing();
            var obj = new Obj();
            thing.func();
            obj.func();
            Console.ReadLine();
        }
    }
}
