using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsUI.Extensions
{
    public static class ConsoleHelpers
    {
        public static string RequestString(this string message)
        {
            Console.Write(message);
            var result = Console.ReadLine()!;
            return result;
        }

        public static int RequestAge(this string message, int min, int max)
        {
            int result;
            bool isValid = false;
            do
            {
                Console.Write(message);
                isValid = int.TryParse(Console.ReadLine(), out result);
                if (isValid == false)
                {
                    Console.WriteLine($"Invalid response, try again");
                }
            } while (isValid && (max >= result && result >= min) == false);

            return result;
        }
    }
}
