using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _1870_Minimum_Speed_to_Arrive_on_Time
    {
        //runtime 30%
        //time complexity O(d*logn)
        public static int MinSpeedOnTime(int[] dist, double hour)
        {
            var left = 1;
            var right = 10000001;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(dist, hour, mid))
                    right = mid;
                else
                    left = mid + 1;
            }

            return left == 10000001 ? -1 : left;
        }

        private static bool Check(int[] dist, double hour, int speed)
        {
            var time = 0d;

            for (int i = 0; i < dist.Length - 1; i++)
            {
                time += (int)Math.Ceiling((double)dist[i] / speed);
            }

            time += (double)dist[dist.Length - 1] / speed;

            return time > hour ? false : true;
        }
    }
}
