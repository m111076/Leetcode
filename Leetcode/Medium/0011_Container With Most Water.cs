using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0011_Container_With_Most_Water
    {
        //runtime 99%
        //time complexity O(n)
        //space complexity O(1)
        //雙指標
        public int MaxArea(int[] height)
        {
            var result = 0;
            var left = 0;
            var right = height.Length - 1;

            while (right > left)
            {
                result = Math.Max(result, Math.Min(height[right], height[left]) * (right - left));

                if (height[right] > height[left])
                    left++;
                else
                    right--;
            }

            return result;
        }
    }
}
