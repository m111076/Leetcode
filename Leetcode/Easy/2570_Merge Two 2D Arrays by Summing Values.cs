using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2570_Merge_Two_2D_Arrays_by_Summing_Values
    {
        public int[][] MergeArrays(int[][] nums1, int[][] nums2)
        {
            var result = new List<int[]>();
            var i = 0;
            var j = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                var idx1 = nums1[i][0];
                var idx2 = nums2[j][0];
                var value1 = nums1[i][1];
                var value2 = nums2[j][1];

                if (idx1 < idx2)
                {
                    result.Add(new int[] { idx1, value1 });
                    i++;
                }
                else if (idx1 > idx2)
                {
                    result.Add(new int[] { idx2, value2 });
                    j++;
                }
                else
                {
                    result.Add(new int[] { idx1, value1 + value2 });
                    i++;
                    j++;
                }
            }

            while (i < nums1.Length)
            {
                result.Add(nums1[i]);
                i++;
            }

            while (j < nums2.Length)
            {
                result.Add(nums1[j]);
                j++;
            }

            return result.ToArray();

        }
    }
}
