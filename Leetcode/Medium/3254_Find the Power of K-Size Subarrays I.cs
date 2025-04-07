using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _3254_Find_the_Power_of_K_Size_Subarrays_I
    {
        //runtime 100%
        //Time complexity O(n)
        //Space complexity O(n)
        //slidingWindow
        public int[] ResultsArray(int[] nums, int k)
        {
            var idx = 0;
            var result = new int[nums.Length - k + 1];
            var passIdx = 0;
            var consecutiveAmount = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i - 1] + 1 == nums[i])
                {
                    consecutiveAmount++;
                }

                if (i - passIdx + 1 > k)
                {
                    if (nums[passIdx] + 1 == nums[passIdx + 1])
                    {
                        consecutiveAmount--;
                    }
                    passIdx++;
                }

                if (i - passIdx + 1 == k)
                {
                    result[idx] = consecutiveAmount == k ? nums[i] : -1;
                    idx++;
                }
            }

            return result;
        }
    }
}
