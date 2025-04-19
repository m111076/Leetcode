using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2563_Count_the_Number_of_Fair_Pairs
    {
        //runtime 100%
        //time complexity O(nlogn) sort為n*logn
        public long CountFairPairs(int[] nums, int lower, int upper)
        {
            Array.Sort(nums);
            return FairPairsCounter(nums, upper) - FairPairsCounter(nums, lower - 1);
        }

        private long FairPairsCounter(int[] iNums, int iVal)
        {
            var result = 0L;

            var right = iNums.Length - 1;

            for (var left = 0; left < right; left++)
            {
                while (right > left && iNums[left] + iNums[right] > iVal)
                {
                    right--;
                }

                result += right - left;
            }

            return result;
        }
    }
}
