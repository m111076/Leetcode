using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    //runtime 87%
    //time complexity O(n)
    //space complexity O(1)
    internal class _1470_Shuffle_the_Array
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var result = new int[nums.Length];

            for (int i = 0; i < n; i++)
            {
                result[i * 2] = nums[i];
                result[i * 2 + 1] = nums[i + n];
            }

            return result;
        }
    }
}
