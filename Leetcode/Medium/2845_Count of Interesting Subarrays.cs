using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2845_Count_of_Interesting_Subarrays
    {
        public long CountInterestingSubarrays(IList<int> nums, int modulo, int k)
        {
            //runtime 0%
            //帶修改
            var count = 0L;
            var equals = 0L;
            var dic = new Dictionary<int, long>();

            dic[0] = 1;

            foreach (int i in nums)
            {
                if (i % modulo == k)
                    equals++;

                int rem = (int)(equals % modulo);
                int needed = (rem - k + modulo) % modulo;

                if (dic.TryGetValue(needed, out long val))
                    count += val;

                if (dic.ContainsKey(rem))
                    dic[rem]++;
                else
                    dic[rem] = 1;
            }

            return count;


            //TLE 609/617
            //var result = 0;

            //for (var i = 0; i < nums.Count; i++)
            //{
            //    var cnt = 0;
            //    for (var j = i; j < nums.Count; j++)
            //    {
            //        if (nums[j] % modulo == k)
            //        {
            //            cnt++;
            //        }
            //        if (cnt % modulo == k)
            //        {
            //            result++;
            //        }
            //    }
            //}

            //return result;
        }
    }
}
