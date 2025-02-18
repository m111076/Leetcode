using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _27_Remove_Element
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int cnt = 0;
            foreach (var item in nums)
            {
                if (item != val)
                {
                    nums[cnt] = item;
                    cnt++;
                }
            }

            return cnt;
        }
    }
}
