using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2226_Maximum_Candies_Allocated_to_K_Children
    {
        //runtime 29%
        //time complexity O(nlogn)
        public int MaximumCandies(int[] candies, long k)
        {
            var left = 1;
            var right = candies.Max() + 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(candies, mid) >= k)
                    left = mid + 1;
                else
                    right = mid;
            }

            return left - 1;
        }

        private long Check(int[] candies, int target)
        {
            var result = 0L;

            foreach (var cand in candies)
            {
                result += cand / target;
            }

            return result;
        }
    }
}
