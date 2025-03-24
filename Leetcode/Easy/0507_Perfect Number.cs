using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0507_Perfect_Number
    {
        public bool CheckPerfectNumber(int num)
        {
            if (num <= 1)
                return false;

            var sqrt = (int)Math.Sqrt(num);
            var sum = 0;

            for (var i = 1; i <= sqrt; i++)
            {
                if (num % i == 0)
                {
                    sum += i + num / i;
                }
            }

            return sum - num == num;
        }
    }
}
