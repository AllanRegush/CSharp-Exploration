using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    { 
        public unsafe struct Foo
        {
            public double x;
            public double y;
        }

        unsafe static void DoPointers()
        {
            Foo foo = new Foo();
            Foo* fooRef = &foo;
        }

        static void Main(string[] args)
        {
            DoPointers();
            unsafe
            {
                Console.WriteLine(sizeof(Foo));
                void* SomeMemory = (void*)Marshal.AllocHGlobal(1000 * sizeof(Foo));
                Marshal.FreeHGlobal((IntPtr)SomeMemory);
            }
            Console.ReadLine();
        }
    }
}
