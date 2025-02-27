using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _1749_Maximum_Absolute_Sum_of_Any_Subarray
    {
        public int MaxAbsoluteSum(int[] nums)
        {
            //run time100% memory 67%
            //兩次Kadane algorithm，一次取最大值，一次取最小值再取絕對值
            var max = int.MinValue;
            var sumMax = 0;
            var min = int.MaxValue;
            var sumMin = 0;

            foreach (int num in nums)
            {
                sumMax += num;
                max = Math.Max(max, sumMax);
                if (sumMax < 0)
                    sumMax = 0;

                sumMin += num;
                min = Math.Min(min, sumMin);
                if (sumMin > 0)
                    sumMin = 0;
            }

            return Math.Max(max, Math.Abs(min));
        }
    }
}
