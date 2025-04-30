using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0852_Peak_Index_in_a_Mountain_Array
    {
        public int PeakIndexInMountainArray(int[] arr)
        {
            //runtime 100%
            //time complexity O(log n)
            //二分搜尋法
            var left = 0;
            var right = arr.Length - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (arr[mid] < arr[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }
    }
}
