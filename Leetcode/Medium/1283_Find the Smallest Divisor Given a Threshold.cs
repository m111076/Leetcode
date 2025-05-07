using Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _1283_Find_the_Smallest_Divisor_Given_a_Threshold
    {
        //runtime 66%
        //time complexity O(nlogn)
        //ceiling的用法
        public static int SmallestDivisor(int[] nums, int threshold)
        {
            var max = int.MaxValue;
            var left = 1;
            var right = max;


            while (left < right)
            {
                var mid = left + (right - left) / 2;

                var sum = 0;

                foreach (var num in nums)
                {
                    sum += (int)Math.Ceiling((double)num / mid);
                }

                if (sum <= threshold)
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }
    }
}
