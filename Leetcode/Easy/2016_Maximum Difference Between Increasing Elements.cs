using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2016_Maximum_Difference_Between_Increasing_Elements
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public int MaximumDifference(int[] nums)
        {
            var min = int.MaxValue;
            var max = 0;

            foreach (var n in nums)
            {
                min = Math.Min(min, n);
                max = Math.Max(max, n - min);
            }

            if (max == 0)
            {
                return -1;
            }

            return max;
        }
    }
}
