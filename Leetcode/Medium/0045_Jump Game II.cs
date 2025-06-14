using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0045_Jump_Game_II
    {
        //runtime 100%
        public int Jump(int[] nums)
        {
            var farest = 0;
            var step = 0;
            var end = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                farest = Math.Max(farest, nums[i] + i);

                if (i == end)
                {
                    step++;
                    end = farest;
                }
            }

            return step;
        }

        //BS方法之後再事
        //public int Jump(int[] nums)
        //{
        //    if (nums.Length == 1) return 0;

        //    var left = 0;
        //    var right = nums.Length;

        //    while (left < right)
        //    {
        //        var mid = left + (right - left) / 2;
        //        if (Check(nums, mid))
        //            right = mid;
        //        else
        //            left = mid + 1;
        //    }

        //    return left;
        //}

        //private bool Check(int[] nums, int target)
        //{
        //    var steps = 0;
        //    var currentEnd = 0;

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        var tmp = i + nums[i];

        //        if (tmp > currentEnd)
        //        {
        //            steps++;
        //            currentEnd = tmp;
        //        }

        //        if (currentEnd >= nums.Length - 1 && steps <= target)
        //        {
        //            return true;
        //        }

        //        if (steps > target)
        //            return false;
        //    }

        //    return false;
        //}
    }
}
