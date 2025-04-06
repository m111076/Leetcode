using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2389_Longest_Subsequence_With_Limited_Sum
    {
        public int[] AnswerQueries(int[] nums, int[] queries)
        {
            //runtime 12%
            //Time complexity O(nlogn)
            //Space complexity O(n)
            var result = new int[queries.Length];

            Array.Sort(nums);

            var prefixSum = new int[nums.Length + 1];

            for (int i = 1; i <= nums.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + nums[i - 1];
            }

            var zeroCnt = 0;

            for (int i = 0; i < queries.Length; i++)
            {
                var target = BinarySearch(prefixSum, queries[i]);

                if (target == 0)
                {
                    zeroCnt++;
                }
                result[i] = target;
            }

            if (zeroCnt == queries.Length)
            {
                return new int[] { 0 };
            }

            return result;
        }
        private int BinarySearch(int[] prefixSum, int target)
        {
            var left = 0;
            var right = prefixSum.Length - 1;
            while (left < right)
            {
                var mid = (left + right + 1) / 2;
                if (prefixSum[mid] <= target)
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left;
        }
    }
}
