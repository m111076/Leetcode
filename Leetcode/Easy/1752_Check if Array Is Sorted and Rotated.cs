using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _1752_Check_if_Array_Is_Sorted_and_Rotated
    {
        public static bool Check(int[] nums)
        {
            //runtime 100% 
            //shift過後左項>右項只會出現一次 超過一次就是不符合
            var length = nums.Length;
            var cnt = 0;

            for (var i = 0; i < length; i++)
            {
                //尾跟頭也要比一次
                if (nums[(i + 1) % length] < nums[i])
                {
                    cnt++;
                }
                if (1 < cnt)
                    return false;
            }

            return true;
        }
    }
}
