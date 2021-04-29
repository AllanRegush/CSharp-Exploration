using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector<int> vec = new Vector<int>();
            vec.Add(10);
            int item = vec.At(0);
            Console.WriteLine(item);

            vec.Add(1);
            vec.Add(2);

            int itemAtTwo = vec.At(2);

            Console.WriteLine(itemAtTwo);
            Console.WriteLine(vec.Capacity);

            Console.ReadLine();
        }
    }
}
