using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3637_Trionic_Array_I
    {
        public bool IsTrionic(int[] nums)
        {
            var length = nums.Length;
            var i = 1;

            while (i < length && nums[i] > nums[i - 1])
                i++;
            if (i == 1 || i == length) return false;

            var p = i;
            while (i < length && nums[i] < nums[i - 1])
                i++;
            if (i == p || i == length) return false;

            var q = i;
            while (i < length && nums[i] > nums[i - 1])
                i++;

            return i == length;
        }
    }
}
