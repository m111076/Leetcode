using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0287_Find_the_Duplicate_Number
    {
        //runtime 77%
        //time complexity O(n)
        //space complexity O(1)
        ////Floyd's Tortoise and Hare (Cycle Detection)
        public int FindDuplicate(int[] nums)
        {
            var slow = nums[0];
            var fast = nums[nums[0]];

            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            }

            var p1 = 0;
            var p2 = slow;

            while (p1 != p2)
            {
                p1 = nums[p1];
                p2 = nums[p2];
            }

            return p1;
        }
    }
}
