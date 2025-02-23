using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _3105_Longest_Strictly_Increasing_or_Strictly_Decreasing_Subarray
    {
        public static int LongestMonotonicSubarray(int[] nums)
        {
            //修正
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;

            bool? isPositive = null;
            var maxLength = 1;
            var result = 1;

            for (var i = 1; i < nums.Length; i++)
            {
                var sub = nums[i] - nums[i - 1];
                if (sub > 0)
                {
                    if (isPositive == true || isPositive == null)
                        maxLength++;
                    else
                        maxLength = 2;
                    isPositive = true;
                }
                else if (sub < 0)
                {
                    if (isPositive == false || isPositive == null)
                        maxLength++;
                    else
                        maxLength = 2;
                    isPositive = false;
                }
                else
                {
                    maxLength = 1;
                    isPositive = null;
                }
                result = Math.Max(maxLength, result);
            }
            return Math.Max(maxLength, result);


            //runtime 100% memory 20%
            //if (nums.Length == 0) return 0;
            //if (nums.Length == 1) return 1;

            //var isPostive = nums[1] - nums[0] > 0;
            //var isPreZero = false;
            //var maxLength = 1;
            //var result = 0;

            //for (var i = 1; i < nums.Length; i++)
            //{
            //    var target = nums[i] - nums[i - 1];
            //    if (target == 0)
            //    {
            //        result = Math.Max(maxLength, result);
            //        isPreZero = true;
            //        maxLength = 1;
            //    }
            //    else
            //    {
            //        if (isPostive == target > 0 || isPreZero)
            //        {
            //            isPreZero = false;
            //            isPostive = target > 0;
            //            maxLength++;
            //        }
            //        else
            //        {
            //            isPostive = !isPostive;
            //            result = Math.Max(maxLength, result);
            //            maxLength = 1;
            //            maxLength++;
            //        }
            //    }
            //}

            //return Math.Max(maxLength, result);
        }
    }
}
