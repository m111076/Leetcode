using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1011_Capacity_To_Ship_Packages_Within_D_Days
    {
        //runtime 25%
        //time complexity O(nlogw)
        public int ShipWithinDays(int[] weights, int days)
        {
            var left = weights.Max();
            var right = weights.Sum();

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(weights, mid) <= days)
                    right = mid;
                else
                    left = mid + 1;
            }
            return left;
        }

        private int Check(int[] weights, int capacity)
        {
            var result = 0;
            var idx = 0;

            while (idx < weights.Length)
            {
                var tmpW = 0;
                while (idx < weights.Length && tmpW < capacity)
                {
                    if (tmpW + weights[idx] <= capacity)
                    {
                        tmpW += weights[idx++];
                    }
                    else
                        break;
                }
                result++;
            }

            return result;
        }
    }
}
