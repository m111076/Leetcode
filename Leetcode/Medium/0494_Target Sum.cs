using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _0494_Target_Sum
    {
        //total = A+B
        //Target = A-B
        //=>A = (total+target)/2
        //find dp[A]
        //runtime 97%
        public static int FindTargetSumWays(int[] nums, int target)
        {
            var total = 0;

            foreach (var num in nums)
            {
                total += num;
            }

            if (total < Math.Abs(target) || ((total + target) & 1) != 0)
                return 0;

            var targetSum = (total + target) / 2;
            var dp = new int[targetSum + 1];
            dp[0] = 1;

            foreach (var num in nums)
            {
                for (var i = targetSum; i >= num; i--)
                {
                    dp[i] += dp[i - num];
                }
            }

            return dp[targetSum];
        }


        //runtime 58%
        //遞迴算法
        //private Dictionary<string, int> dic = new Dictionary<string, int>();
        //public int FindTargetSumWays(int[] nums, int target)
        //{
        //    var idx = nums.Length - 1;
        //    var sum = 0;
        //    return DP(nums, target, idx, sum);
        //}

        //public int DP(int[] nums, int target, int index, int sum)
        //{
        //    var key = $"{index},{sum}";

        //    if (dic.TryGetValue(key, out var value))
        //        return value;

        //    if (index < 0 && sum == target)
        //        return 1;

        //    if (index < 0)
        //        return 0;

        //    var pos = DP(nums, target, index - 1, sum + nums[index]);
        //    var neg = DP(nums, target, index - 1, sum - nums[index]);

        //    dic[key] = pos + neg;

        //    return dic[key];
        //}
    }
}
