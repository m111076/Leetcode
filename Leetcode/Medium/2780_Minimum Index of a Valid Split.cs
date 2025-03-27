using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2780_Minimum_Index_of_a_Valid_Split
    {
        public int MinimumIndex(IList<int> nums)
        {
            //runtime 75%
            var target = 0;
            var cnt = 0;

            foreach (var num in nums)
            {
                if (cnt == 0)
                    target = num;

                if (num == target)
                    cnt++;
                else
                    cnt--;
            }

            if (cnt == 0)
                return -1;

            var targetAmount = nums.Count(n => n == target);
            var tmpAmount = 0;

            for (var i = 0; i < nums.Count; i++)
            {
                if (nums[i] == target)
                    tmpAmount++;

                if (tmpAmount * 2 > i + 1 && (targetAmount - tmpAmount) * 2 > nums.Count - i - 1)
                    return i;
            }

            return -1;
        }
    }
}
