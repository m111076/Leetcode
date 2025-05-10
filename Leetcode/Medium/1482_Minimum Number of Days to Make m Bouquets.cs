using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1482_Minimum_Number_of_Days_to_Make_m_Bouquets
    {
        //runtime 70%
        //timecomplexity O(logn*n)
        public int MinDays(int[] bloomDay, int m, int k)
        {
            if (bloomDay.Length < (long)m * k)
                return -1;

            var left = 0;
            var right = 1000000000;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(bloomDay, mid, m, k))
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }


        private bool Check(int[] bloomDay, int day, int m, int k)
        {
            var result = 0L;
            var amount = 0;

            for (var i = 0; i < bloomDay.Length; i++)
            {
                if (bloomDay[i] <= day)
                    amount++;
                else
                {
                    result += amount / k;
                    amount = 0;
                }
            }
            result += amount / k;

            return result >= m;
        }
    }
}
