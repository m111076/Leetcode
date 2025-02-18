using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _2342_Max_Sum_of_a_Pair_With_Equal_Sum_of_Digits
    {
        public static int MaximumSum(int[] nums)
        {
            var tempDic = new Dictionary<int, int>();
            var max = -1;

            foreach (var num in nums)
            {
                var total = 0;
                var target = num;
                while (target != 0)
                {
                    total += (target % 10);
                    target /= 10;
                }

                if (tempDic.TryGetValue(total, out var value))
                {
                    max = Math.Max(max, value + num);
                    tempDic[total] = Math.Max(value, num);
                }
                else
                {
                    tempDic[total] = num;
                }
            }
            return max;
        }
    }
}
