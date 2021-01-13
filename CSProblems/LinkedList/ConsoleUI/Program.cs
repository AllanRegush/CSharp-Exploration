using System;
using LinkedListLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(10);
            list.Add(11);
            list.Add(13);
            list.Find(10);
            Console.WriteLine($"{list.Count}, {list.At(2)}, {list.Find(10)}");
            Console.ReadLine();
        }
    }
}
