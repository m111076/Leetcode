using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2956_Find_Common_Elements_Between_Two_Arrays
    {
        //runtime 76%
        //time complexity O(n)
        //space complexity O(1)
        public int[] FindIntersectionValues(int[] nums1, int[] nums2)
        {
            var tmp1 = new int[101];
            var tmp2 = new int[101];

            foreach (var num in nums1)
            {
                tmp1[num]++;
            }
            foreach (var num in nums2)
            {
                tmp2[num]++;
            }

            var result = new int[2];

            for (var i = 1; i <= 100; i++)
            {
                if (tmp1[i] != 0 && tmp2[i] != 0)
                {
                    result[0] += tmp1[i];
                    result[1] += tmp2[i];
                }
            }

            return result;
        }
    }
}
