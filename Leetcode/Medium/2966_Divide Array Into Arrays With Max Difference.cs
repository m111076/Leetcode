using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2966_Divide_Array_Into_Arrays_With_Max_Difference
    {
        //runtime 64%
        //time complexity O(nlogn)
        //space complexity O(n)
        //先排序 然後依序取三個
        public int[][] DivideArray(int[] nums, int k)
        {
            Array.Sort(nums);
            var result = new List<int[]>();

            for (var i = 0; i < nums.Length - 2; i += 3)
            {
                if (nums[i + 2] - nums[i] > k)
                {
                    return new int[0][];
                }
                else
                {
                    result.Add(new int[] { nums[i], nums[i + 1], nums[i + 2] });
                }
            }

            return result.ToArray();
        }
    }
}
