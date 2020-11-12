using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
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
                CallMe();
                MethodNotImplemented();
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("A method was not implemented");
                Console.WriteLine(ex.Message);
            }
            catch 
            {
                Console.WriteLine("I catch all other exceptions");
            }
            finally
            {
                Console.WriteLine("I always run");
            }

            Console.ReadLine();
        }

        private static void CallMe()
        {
            throw new Exception("Don't call me");
        }

        private static void MethodNotImplemented()
        {
            throw new NotImplementedException("This method is not implemented");
        }
    }
}
