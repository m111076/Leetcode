using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _0198_House_Robber
    {
        //runtime 100%
        //DP問題
        //建立DP[i]表儲存前i個選擇時可偷到的最多錢
        //當選擇i時 其必不可能偷第i-1個，所以必定是選擇i-2的值
        //之後比較DP[i] = Max(nums[i]+DP[i-2],DP[i-1])
        public int Rob(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            var pre = 0;
            var post = 0;

            for (var i = 2; i < nums.Length; i++)
            {
                var tmp = post;
                post = Math.Max(post, pre + nums[i]);
                pre = tmp;
            }

            return post;
        }
    }
}
