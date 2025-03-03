using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2161_Partition_Array_According_to_Given_Pivot
    {
        public int[] PivotArray(int[] nums, int pivot)
        {
            //2pointer?
            //runtime 90%
            var length = nums.Length;
            var result = new int[nums.Length];
            var smallIdx = 0;
            var largeIdx = length - 1;

            for (var i = 0; i < length; i++)
            {
                if (nums[i] < pivot)
                    result[smallIdx++] = nums[i];
                if (nums[length - 1 - i] > pivot)
                    result[largeIdx--] = nums[length - 1 - i];
            }

            while(smallIdx <= largeIdx)
            {
                result[smallIdx++] = pivot;
            }

            return result;

            //速度依樣慢
            //return nums.Where(n => n < pivot).Concat(nums.Where(n => n == pivot)).Concat(nums.Where(n => n > pivot)).ToArray();

            //runtime 6.9%
            //var smallTarget = nums.Where(n => n < pivot).ToList();
            //var biggerTarget = nums.Where(n => n > pivot).ToList();
            //var pivotAmount = nums.Length - smallTarget.Count - biggerTarget.Count;

            //for (var i = 0; i < pivotAmount; i++)
            //{
            //    smallTarget.Add(pivot);
            //}

            //return smallTarget.Concat(biggerTarget).ToArray();
        }
    }
}
