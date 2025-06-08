using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    internal class _0410_Split_Array_Largest_Sum
    {
        //runtime 95.75%
        //time complexity O(nlogn)
        //space complexity O(1)
        //難的是要理解題目，可以套用到BS上面
        //目標是要在k個分區下找出子集合最大合的最小值
        //當值越小，分區數量就會越多
        //所以我們可以透過BS來搜尋滿足K個分段的最小值
        public int SplitArray(int[] nums, int k)
        {
            var max = 0;
            var sum = 0;

            foreach (var num in nums)
            {
                max = Math.Max(max, num);
                sum += num;
            }

            var left = max;
            var right = sum + 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(nums, k, mid))
                    right = mid;
                else
                    left = mid + 1;
            }

            return left;
        }

        private bool Check(int[] nums, int k, int mid)
        {
            var cnt = 1;
            var tmpSum = 0;

            foreach (var num in nums)
            {
                if (num + tmpSum <= mid)
                {
                    tmpSum += num;
                    continue;
                }

                if (cnt++ == k)
                    return false;

                tmpSum = num;
            }

            return true;
        }
    }
}
