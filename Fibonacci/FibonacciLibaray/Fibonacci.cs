using System;
using System.Collections.Generic;

namespace FibonacciLibaray
{
    public static class Fibonacci
    {
        static private Dictionary<int, int> memo = new Dictionary<int, int>() { { 0, 0 }, { 1, 1 } };
        
        public static int fib1(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return fib1(n - 2) + fib1(n - 1);
        }

        public static int fib2(int n)
        {
            if (memo.ContainsKey(n) == false)
            {
                memo.Add(n, fib2(n - 2) + fib2(n - 1));
            }
            return memo[n];
        }

        public static int fib3(int n)
        {
            if (n == 0)
            {
                return n;
            }
            int last = 0;
            int next = 1;
            for(int i = 1; 0 < n; ++i)
            {
                int temp = last;
                last = next;
                next = next + temp;
            }
            return next;
        }
    }
}
