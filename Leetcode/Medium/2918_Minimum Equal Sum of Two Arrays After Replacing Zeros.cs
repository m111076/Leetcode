using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2918_Minimum_Equal_Sum_of_Two_Arrays_After_Replacing_Zeros
    {
        //runtime 72%
        //time complexity O(n)
        public long MinSum(int[] nums1, int[] nums2)
        {
            var zeroCnt1 = 0L;
            var sum1 = 0L;

            //O(n)
            foreach (var num in nums1)
            {
                sum1 += num != 0 ? num : 1;
                if (num == 0)
                    zeroCnt1++;
            }

            var zeroCnt2 = 0L;
            var sum2 = 0L;

            //O(n)
            foreach (var num in nums2)
            {
                sum2 += num != 0 ? num : 1;
                if (num == 0)
                    zeroCnt2++;
            }

            if (sum1 > sum2 && zeroCnt2 == 0)
                return -1;
            if (sum1 < sum2 && zeroCnt1 == 0)
                return -1;

            return Math.Max(sum1, sum2);
        }
    }
}
