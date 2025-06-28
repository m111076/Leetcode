using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2099_Find_Subsequence_of_Length_K_With_the_Largest_Sum
    {
        public int[] MaxSubsequence(int[] nums, int k)
        {
            //runtime 76%
            //time complexity O(nlogn)
            //space complexity O(n)
            if (k == nums.Length)
                return nums;

            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

            for (int i = 0; i < nums.Length; i++)
            {
                pq.Enqueue(i, nums[i]);
            }

            var result = new int[k];

            for (var i = k - 1; i >= 0; i--)
            {
                result[i] = pq.Dequeue();
            }

            Array.Sort(result);

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = nums[result[i]];
            }

            return result;
            //runtime 22%
            //time complexity O(nlogn)
            //space complexity O(n)
            //if (k == nums.Length)
            //    return nums;

            //var tmp = new List<(int value, int index)>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    tmp.Add((nums[i], i));
            //}

            //tmp.Sort((a, b) => (b.value.CompareTo(a.value)));
            //var topTmp = tmp.Take(k).OrderBy(a => a.index).Select(a => a.value).ToList();

            //return topTmp.ToArray();
        }
    }
}
