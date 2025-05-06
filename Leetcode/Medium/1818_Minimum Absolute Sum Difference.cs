using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _1818_Minimum_Absolute_Sum_Difference
    {
        //runtime 100%
        //time complexity O(nlogn)
        //Binary Search
        public static int MinAbsoluteSumDiff(int[] nums1, int[] nums2)
        {
            var sum = 0L;
            var max = 0L;
            var tmp = (int[])nums1.Clone();

            Array.Sort(tmp);

            for (int i = 0; i < nums1.Length; i++)
            {
                var t = Math.Abs(nums1[i] - nums2[i]);

                if (t == 0)
                    continue;

                sum += t;

                var left = 0;
                var right = tmp.Length;

                while (left < right)
                {
                    var mid = left + (right - left) / 2;

                    if (tmp[mid] >= nums2[i])
                        right = mid;
                    else
                        left = mid + 1;
                }

                var tmpMin = int.MaxValue;
                if (left < tmp.Length)
                    tmpMin = Math.Abs(tmp[left] - nums2[i]);
                if (left - 1 >= 0)
                {
                    var pret = Math.Abs(tmp[left - 1] - nums2[i]);
                    tmpMin = Math.Min(tmpMin, pret);
                }
                if (t > tmpMin)
                    max = Math.Max(max, t - tmpMin);
            }

            return (int)((sum - max) % 1000000007);
        }
    }
}
