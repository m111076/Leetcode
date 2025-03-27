using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0509_Fibonacci_Number
    {
        public int Fib(int n)
        {
            //runtime 69%
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            var a = 0;
            var b = 1;

            for (int i = 2; i <= n; i++)
            {
                var temp = a + b;
                a = b;
                b = temp;
            }

            return b;


            //runtime 20%
            //效率差
            //if (n == 0)
            //    return 0;
            //if (n == 1)
            //    return 1;

            //return Fib(n - 1) + Fib(n - 2);
        }
    }
}
