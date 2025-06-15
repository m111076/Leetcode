using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3583_Count_Special_Triplets
    {
        //runtime 92%
        //time complexity O(n)
        //space complexity O(n)
        public int SpecialTriplets(int[] nums)
        {
            var mod = 1_000_000_007;
            var rights = new Dictionary<int, int>();
            var lefts = new Dictionary<int, int>();
            var result = 0L;

            foreach (var n in nums)
            {
                if (!rights.TryAdd(n, 1))
                {
                    rights[n]++;
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                rights[nums[i]]--;

                var target = nums[i] * 2;
                long right = rights.GetValueOrDefault(target);
                long left = lefts.GetValueOrDefault(target);
                result = (result + right * left) % mod;

                if (!lefts.TryAdd(nums[i], 1))
                    lefts[nums[i]]++;
            }

            return (int)result;
        }
    }
}
