using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2529_Maximum_Count_of_Positive_Integer_and_Negative_Integer
    {
        //runtime 100%
        //time complexity O(logn)
        public int MaximumCount(int[] nums)
        {
            return Math.Max(binarySearch(nums, 0), nums.Length - binarySearch(nums, 1));
        }

        private int binarySearch(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] >= target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return left;
        }

        //public int MaximumCount(int[] nums)
        //{
        //    int negCount = BinarySearch(nums, 0);
        //    int posCount = nums.Length - BinarySearch(nums, 1);
        //    return Math.Max(negCount, posCount);
        //}
        //private int BinarySearch(int[] nums, int target)
        //{
        //    int left = 0, right = nums.Length - 1, result = nums.Length;

        //    while (left <= right)
        //    {
        //        int mid = (left + right) / 2;
        //        if (nums[mid] < target)
        //        {
        //            left = mid + 1;
        //        }
        //        else
        //        {
        //            result = mid;
        //            right = mid - 1;
        //        }
        //    }

        //    return result;
        //}
    }
}
