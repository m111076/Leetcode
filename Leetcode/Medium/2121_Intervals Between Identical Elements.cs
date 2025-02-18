using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _2121_Intervals_Between_Identical_Elements
    {
        public static long[] GetDistances(int[] arr)
        {
            var l = arr.Length;
            var ans = new long[l];
            var dic = new Dictionary<long, long>();

            for (var i = 0; i < l; i++)
            {
                if (!dic.ContainsKey(arr[i]))
                {
                    dic.Add(i, arr[i]);
                    ans[i] = 0;
                }
                else
                {
                    dic.Add(i, arr[i]);
                    ans[i] = 0;
                    var targets = dic.Where(d => d.Value == arr[i]);
                    foreach (var target in targets)
                    {
                        ans[i] += Math.Abs(target.Key - i);
                    }
                }
            }
            return ans;
        }
    }
}
