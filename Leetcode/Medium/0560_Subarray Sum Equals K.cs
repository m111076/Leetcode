using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0560_Subarray_Sum_Equals_K
    {
        //runtime 47%
        //time complexity O(n)
        //space complexity O(n)
        //透過前綴和來計算
        //初始狀態要記得
        public int SubarraySum(int[] nums, int k)
        {
            var sumDic = new Dictionary<int, int>() { { 0, 1 } };
            var tmpSum = 0;
            var result = 0;


            foreach (var i in nums)
            {
                tmpSum += i;

                if (sumDic.TryGetValue(tmpSum - k, out var cnt))
                    result += cnt;

                if (sumDic.ContainsKey(tmpSum))
                    sumDic[tmpSum]++;
                else
                    sumDic.Add(tmpSum, 1);
            }

            return result;
        }
    }
}
