using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRun> runner = new List<IRun>();
            runner.Add(new Person());
            runner.Add(new Animal());

            foreach (IRun run in runner)
            {
                run.Running();
            }

            Console.ReadLine();
        }
    }
}
