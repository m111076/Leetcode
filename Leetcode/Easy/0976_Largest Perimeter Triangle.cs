using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0976_Largest_Perimeter_Triangle
    {
        public int LargestPerimeter(int[] nums)
        {
            //runtime 43%
            //反向做應該可以更快
            Array.Sort(nums);

            var a = nums[0];
            var b = nums[1];
            var max = 0;

            for (int i = 2; i < nums.Length; i++)
            {
                var c = nums[i];
                if (a + b > c)
                    max = Math.Max(max, a + b + c);
                a = b;
                b = c;
            }

            return max;
        }
    }
}
