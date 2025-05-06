using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1920_Build_Array_from_Permutation
    {
        //runtime 12%
        //time complexity O(n)
        //space complexity O(1)=>題目限制條件
        //使用補數做為已調整過(-x = ~x+1)
        public int[] BuildArray(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                var target = nums[i];

                if (target < 0)
                    continue;

                var cur = i;

                while (nums[cur] != i)
                {
                    var next = nums[cur];
                    nums[cur] = ~nums[next];
                    cur = next;
                }
                nums[cur] = ~target;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = ~nums[i];
            }

            return nums;
        }
    }
}
