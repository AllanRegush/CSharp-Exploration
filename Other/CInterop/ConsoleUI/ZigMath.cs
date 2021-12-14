using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleUI
{
    internal static class ZigMath
    {
        [DllImport("ziglib.dll")]
        extern public static int add(int a, int b);
    }
}
