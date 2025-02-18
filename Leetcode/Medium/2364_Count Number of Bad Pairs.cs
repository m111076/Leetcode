using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _2364_Count_Number_of_Bad_Pairs
    {
        public static long CountBadPairs(int[] nums)
        {
            long count = 0;
            Dictionary<int, int> freq = new(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                int n = i - nums[i];
                int matches = freq[n] = freq.GetValueOrDefault(n) + 1;
                count += i - matches + 1;
            }
            return count;

            ///List速度太慢
            //long goodCnt = 0;
            //var substract = new Dictionary<long, long>();
            //for (var i = 0; i < nums.Length; i++)
            //{
            //    var val = nums[i] - i;
            //    if (!substract.TryAdd(val, 1))
            //        substract[val]++;
            //}

            //foreach (var s in substract)
            //{
            //    goodCnt += s.Value * (s.Value - 1) / 2;
            //}
            //return nums.Length * (nums.Length - 1) / 2 - goodCnt;


            //var dict = new Dictionary<long, long>();
            //long n = nums.Length;
            //for (int i = 0; i < n; i++)
            //{
            //    var val = nums[i] - i;
            //    if (dict.TryAdd(val, 1) == false)
            //    {
            //        dict[val]++;
            //    }
            //}

            //long pairs = (n - 1) * n / 2;
            //foreach (var val in dict.Values)
            //{
            //    long posPairs = val * (val - 1) / 2;
            //    pairs -= posPairs;
            //}
            //return pairs;
        }
    }
}
