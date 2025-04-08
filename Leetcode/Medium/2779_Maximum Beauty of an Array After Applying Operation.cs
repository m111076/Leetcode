using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2779_Maximum_Beauty_of_an_Array_After_Applying_Operation
    {
        public int MaximumBeauty(int[] nums, int k)
        {
            //runtime 53.85%
            //time complexity O(nlogn) sort
            //space complexity O(1)
            //slidingWindow
            Array.Sort(nums);
            var left = 0;
            var right = 0;

            for (right = 0; right < nums.Length; right++)
            {
                if (nums[right] - nums[left] > 2 * k)
                    left++;
            }

            return right - left;
        }
    }
}
