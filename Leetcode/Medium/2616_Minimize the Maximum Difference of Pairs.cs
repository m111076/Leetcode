using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2616_Minimize_the_Maximum_Difference_of_Pairs
    {
        //runtime 82%
        //time complexityO(logn * n)
        //space complexity O(1)
        //BS
        public int MinimizeMax(int[] nums, int p)
        {
            Array.Sort(nums);

            var left = 0;
            var right = nums[^1] - nums[0];

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(nums, p, mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }


        private bool Check(int[] nums, int p, int target)
        {
            var cnt = 0;
            var idx = 0;

            while (idx < nums.Length - 1)
            {
                if (Math.Abs(nums[idx] - nums[idx + 1]) <= target)
                {
                    cnt++;
                    idx += 2;
                }
                else
                {
                    idx++;
                }

                if (cnt >= p)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
