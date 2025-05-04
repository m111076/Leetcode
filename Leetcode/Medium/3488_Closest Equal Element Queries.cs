using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal static class _3488_Closest_Equal_Element_Queries
    {
        //runtime 24%
        //
        public static IList<int> SolveQueries(int[] nums, int[] queries)
        {
            var dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.TryAdd(nums[i], new List<int>() { i }))
                    dict[nums[i]].Add(i);
            }

            foreach (var d in dict)
            {
                var i = d.Value[0];
                d.Value.Insert(0, d.Value[d.Value.Count - 1] - nums.Length);
                d.Value.Add(i + nums.Length);
            }

            var result = new List<int>();

            foreach (var q in queries)
            {
                var tar = nums[q];
                var targets = dict[tar];
                if (targets.Count == 3)
                {
                    result.Add(-1);
                    continue;
                }

                var t = targets.BinarySearch(q);
                result.Add(Math.Min(q - targets[t - 1], targets[t + 1] - q));

            }

            return result;

        }
    }
}
