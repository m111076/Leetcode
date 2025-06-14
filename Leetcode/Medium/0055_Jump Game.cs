using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0055_Jump_Game
    {
        //runtime 63%
        //time complexity O(n)
        //space complexity O(1)
        //若當下能走到的最遠位置就是當前座標，代表沒辦法繼續下去
        public bool CanJump(int[] nums)
        {
            var farest = 0;

            for (var i = 0; i < nums.Length - 1; i++)
            {
                farest = Math.Max(farest, i + nums[i]);
                if (farest == i)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
