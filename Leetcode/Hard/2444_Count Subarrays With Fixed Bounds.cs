using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _2444_Count_Subarrays_With_Fixed_Bounds
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //紀錄minK、maxK以及不介於這兩數之間的index
        //先比較minK、maxK的index，取最小值
        //tmpIdx+1~minIdx是可以作為起始點的範圍
        public long CountSubarrays(int[] nums, int minK, int maxK)
        {
            var result = 0L;
            var tmpIdx = -1;
            var minIdx = -1;
            var maxIdx = -1;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] < minK || nums[i] > maxK)
                    tmpIdx = i;

                if (nums[i] == minK)
                    minIdx = i;

                if (nums[i] == maxK)
                    maxIdx = i;

                var min = Math.Min(minIdx, maxIdx);

                result += Math.Max(0, min - tmpIdx);
            }

            return result;
        }
    }
}
