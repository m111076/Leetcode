using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _3296_Minimum_Number_of_Seconds_to_Make_Mountain_Height_Zero
    {
        //runtime 50%
        //time complexity O(w+logn*w*logm)
        public static long MinNumberOfSeconds(int mountainHeight, int[] workerTimes)
        {
            var left = 1L;
            var max = (long)workerTimes.Max();
            var right = max * (mountainHeight + 1) * mountainHeight / 2;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(workerTimes, mountainHeight, mid) < mountainHeight)
                    left = mid + 1;
                else
                    right = mid;
            }

            return left;
        }

        private static long Check(int[] workerTimes, int mountainHeight, long targetTime)
        {
            var result = 0L;

            foreach (var workerTime in workerTimes)
            {
                var left = 0L;
                var right = (long)mountainHeight;

                while (left < right)
                {
                    var mid = left + (right - left + 1) / 2;
                    var t = workerTime * mid * (mid + 1) / 2;

                    if (t <= targetTime)
                        left = mid;
                    else
                        right = mid - 1;
                }

                result += left;
            }

            return result;
        }
    }
}
