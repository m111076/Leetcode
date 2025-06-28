using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1498_Number_of_Subsequences_That_Satisfy_the_Given_Sum_Condition
    {
        public int NumSubseq(int[] nums, int target)
        {
            //runtime 97%
            //time complexity O(nlogn)
            //space complexity O(n)
            Array.Sort(nums);
            var left = 0;
            var right = nums.Length - 1;
            var mod = 1000000007;
            var pow = new int[nums.Length];
            pow[0] = 1;
            var result = 0;

            for (var i = 1; i < nums.Length; i++)
            {
                pow[i] = pow[i - 1] * 2 % mod;
            }

            while (left <= right)
            {
                if (nums[left] + nums[right] <= target)
                {
                    result = (result + pow[right - left]) % mod;
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return result;
        }
    }
}
