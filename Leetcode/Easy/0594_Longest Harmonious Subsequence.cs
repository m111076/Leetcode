using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal static class _0594_Longest_Harmonious_Subsequence
    {
        public static int FindLHS(int[] nums)
        {
            //runtime 93%
            //time complexity O(n)
            //space complexity O(n)
            var dic = new Dictionary<int, int>();
            var result = 0;

            foreach (var n in nums)
            {
                if (!dic.TryAdd(n, 1))
                    dic[n]++;
            }

            foreach (var key in dic.Keys)
            {
                if (dic.TryGetValue(key + 1, out var cnt))
                {
                    result = Math.Max(result, dic[key] + cnt);
                }
            }

            return result;

            //runtime 23%
            //time complexity O(nlogn)
            //space complexity O(1)
            //Array.Sort(nums);

            //var preValue = 0;
            //var preCnt = 0;
            //var curValue = 0;
            //var curCnt = 0;
            //var result = 0;

            //foreach (var n in nums)
            //{
            //    if (curCnt == 0)
            //    {
            //        curValue = n;
            //        curCnt++;
            //        continue;
            //    }

            //    if (curValue != n)
            //    {
            //        if (preCnt != 0)
            //        {
            //            if (curValue - preValue == 1)
            //            {
            //                result = Math.Max(result, preCnt + curCnt);
            //            }
            //        }
            //        preValue = curValue;
            //        preCnt = curCnt;
            //        curValue = n;
            //        curCnt = 1;
            //    }
            //    else
            //        curCnt++;
            //}

            //if (preCnt > 0 && curValue - preValue == 1)
            //{
            //    result = Math.Max(result, preCnt + curCnt);
            //}

            //return result;
        }
    }
}
