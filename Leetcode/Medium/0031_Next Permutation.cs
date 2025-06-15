using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0031_Next_Permutation
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public void NextPermutation(int[] nums)
        {
            var length = nums.Length;
            var idx = length - 2;

            while (idx >= 0 && (nums[idx] >= nums[idx + 1]))
            {
                idx--;
            }

            if (idx >= 0)
            {
                var target = length - 1;

                while (nums[target] <= nums[idx])
                {
                    target--;
                }

                var tmp = nums[target];
                nums[target] = nums[idx];
                nums[idx] = tmp;
            }

            var left = idx + 1;
            var right = length - 1;

            while (left < right)
            {
                var tmp = nums[left];
                nums[left++] = nums[right];
                nums[right--] = tmp;
            }
        }
    }
}
