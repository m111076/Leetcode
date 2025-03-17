using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _0213_House_Robber_II
    {
        //runtime 100%
        //與198相同
        //因為頭尾相連 因此須可以比較 頭不選 或尾不選的值
        public int Rob(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            return Math.Max(check(0, nums.Length - 1, nums), check(1, nums.Length, nums));
        }

        public int check(int iStart, int iEnd, int[] nums)
        {
            var pre = 0;
            var post = 0;

            for (var i = iStart; i < iEnd; i++)
            {
                var tmp = post;
                post = Math.Max(post, pre + nums[i]);
                pre = tmp;
            }
            return post;
        }
    }
}
