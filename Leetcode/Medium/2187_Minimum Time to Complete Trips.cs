using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Leetcode.Medium._0981_Time_Based_Key_Value_Store;

namespace Leetcode.Medium
{
    internal static class _2187_Minimum_Time_to_Complete_Trips
    {
        //runtime 70%
        //time complexity O(n+tlogn)
        //重點在right邊界值
        public static long MinimumTime(int[] time, int totalTrips)
        {
            var left = 1L;
            //O(n)
            var right = (long)time.Min() * totalTrips;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(time, mid) >= totalTrips)
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }

        private static long Check(int[] times, long time)
        {
            var result = 0L;

            foreach (var t in times)
            {
                result += time / t;
            }

            return result;
        }
    }
}
