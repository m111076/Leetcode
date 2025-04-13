using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _1922_Count_Good_Numbers
    {
        //runtime 100%
        //time complexity: O(log n)
        //space complexity: O(1)
        public int CountGoodNumbers(long n)
        {
            return (int)(Power(5, (n + 1) / 2) * Power(4, n / 2) % 1000000007);
        }
        private long Power(long num1, long num2)
        {
            if (num2 == 0)
                return 1;

            var tmp = Power(num1, num2 / 2);

            return tmp * tmp * (num2 % 2 == 0 ? 1 : num1) % 1000000007;
        }
    }
}
