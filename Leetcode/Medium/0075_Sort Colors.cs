using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0075_Sort_Colors
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //用Sort時間複雜度為O(nlogn)
        public void SortColors(int[] nums)
        {
            var zeroCnt = 0;
            var oneCnt = 0;

            foreach (var i in nums)
            {
                if (i == 0)
                {
                    zeroCnt++;
                }
                else if (i == 1)
                {
                    oneCnt++;
                }
            }

            var twoCnt = nums.Length - zeroCnt - oneCnt;

            for (var i = 0; i < nums.Length; i++)
            {
                if (i < zeroCnt)
                {
                    nums[i] = 0;
                }
                else if (i < zeroCnt + oneCnt)
                {
                    nums[i] = 1;
                }
                else
                {
                    nums[i] = 2;
                }
            }
        }
    }
}
