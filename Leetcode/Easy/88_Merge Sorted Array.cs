using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _88_Merge_Sorted_Array
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
                return;

            if (m == 0)
            {
                for (var i = 0; i < nums1.Length; i++)
                {
                    nums1[i] = nums2[i];
                }
                return;
            }

            var tempLastIdx = nums1.Length - 1;

            while (m > 0 && n > 0)
            {
                if (nums1[m - 1] <= nums2[n - 1])
                {
                    nums1[tempLastIdx] = nums2[n - 1];
                    n--;
                }
                else
                {
                    nums1[tempLastIdx] = nums1[m - 1];
                    m--;
                }
                tempLastIdx--;
            }

            while (n > 0)
            {
                nums1[tempLastIdx] = nums2[n - 1];
                n--;
                tempLastIdx--;
            }

        }
    }
}
