using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0875_Koko_Eating_Bananas
    {
        //runtime 35%
        //timecomplexity O(p+plogn)
        //取ceiling
        public int MinEatingSpeed(int[] piles, int h)
        {
            var left = 1;
            var right = piles.Max();

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(piles, mid) <= h)
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }

        private int Check(int[] piles, int amount)
        {
            var result = 0;

            foreach (var pile in piles)
            {
                var target = (double)pile;
                result += (int)Math.Ceiling((target / amount));
            }

            return result;
        }
    }
}
