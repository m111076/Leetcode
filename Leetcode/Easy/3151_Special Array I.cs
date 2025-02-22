using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _3151_Special_Array_I
    {
        public static bool IsArraySpecial(int[] nums)
        {
            //Runtime 100% memory 6%
            //XOR特性 
            //true true=>false
            //false false=>false
            //true false=>true
            //false true=>true
            var pre = nums[0] % 2;

            for (var i = 1; i < nums.Length; i++)
            {
                if ((pre ^ (nums[i] % 2)) == 1)
                    pre = nums[i] % 2;
                else
                    return false;
            }

            return true;

        }
    }
}
