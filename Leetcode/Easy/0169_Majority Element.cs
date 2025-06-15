using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0169_Majority_Element
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //莫爾投票法
        public int MajorityElement(int[] nums)
        {
            var target = nums[0];
            var cnt = 1;

            for (var i = 1; i < nums.Length; i++)
            {
                if (target != nums[i])
                {
                    if (--cnt == 0)
                    {
                        target = nums[i];
                        cnt = 1;
                    }
                }
                else
                    cnt++;
            }

            return target;
        }
    }
}
