using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2294_Partition_Array_Such_That_Maximum_Difference_Is_K
    {
        //runtime 100%
        //time complexity O(n log n)
        //space complexity O(1)
        //排序後比大小，相差值大於k就需要一個新的區間
        public int PartitionArray(int[] nums, int k)
        {
            Array.Sort(nums);
            var result = 0;
            var min = int.MinValue / 2;

            foreach (var num in nums)
            {
                if (num - min > k)
                {
                    min = num;
                    result++;
                }
            }

            return result;
        }
    }
}
