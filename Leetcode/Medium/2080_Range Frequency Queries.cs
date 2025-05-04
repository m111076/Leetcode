using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2080_Range_Frequency_Queries
    {
        //runtime 7%
        public class RangeFreqQuery
        {
            public int[] tmp;
            public Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();

            public RangeFreqQuery(int[] arr)
            {
                for (var i = 0; i < arr.Length; i++)
                {
                    if (!dic.TryAdd(arr[i], new List<int>() { i }))
                        dic[arr[i]].Add(i);
                }
            }

            public int Query(int left, int right, int value)
            {
                if (!dic.TryGetValue(value, out var targets))
                    return 0;

                return BS(targets, right + 1) - BS(targets, left);
            }

            private int BS(List<int> ints, int target)
            {
                var left = 0;
                var right = ints.Count;

                while (left < right)
                {
                    var mid = left + (right - left) / 2;

                    if (ints[mid] >= target)
                        right = mid;
                    else
                        left = mid + 1;
                }

                return left;
            }
        }
    }
}
