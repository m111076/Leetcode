using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3010_Divide_an_Array_Into_Subarrays_With_Minimum_Cost_I
    {
        //runtime 44%
        //time complexity O(nlogn)
        //space complexity O(n)
        public int MinimumCost(int[] nums)
        {
            var q = new PriorityQueue<int, int>();

            for (var i = 1; i < nums.Length; i++)
            {
                q.Enqueue(nums[i], nums[i]);
            }

            var result = nums[0];
            var cnt = 0;

            while (cnt < 2)
            {
                result += q.Dequeue();
                cnt++;
            }

            return result;
        }
    }
}
