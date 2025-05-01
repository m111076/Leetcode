using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1695_Maximum_Erasure_Value
    {
        public int MaximumUniqueSubarray(int[] nums)
        {
            //runtime 40%
            //time complexity O(n)
            var left = 0;
            var right = 0;
            var set = new HashSet<int>();
            var sum = 0;
            var result = int.MinValue;

            while (right < nums.Length)
            {
                if (set.Contains(nums[right]))
                {
                    set.Remove(nums[left]);
                    sum -= nums[left];
                    left++;
                }
                else
                {
                    set.Add(nums[right]);
                    sum += nums[right];
                    result = Math.Max(sum, result);
                    right++;
                }
            }
            return result;
        }
    }
}
