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
            try
            {
                throwAfterN(10);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }


        static void throwAfterN(int n)
        {
            for(int i = 0; i < n + 1; ++i)
            {
                if (i == n)
                {
                    throw new Exception($"{ i } equals { n }");
                }
            }
        }
    }
}
