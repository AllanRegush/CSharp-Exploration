using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BubbleSortLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 23, 45, 1, 16 };
            int[] sorted = BubbleSort.Sort(arr);
            foreach(var item in sorted)
            {
                Console.Write($"{ item } ");
            }
            Console.ReadLine();
        }
    }
}
