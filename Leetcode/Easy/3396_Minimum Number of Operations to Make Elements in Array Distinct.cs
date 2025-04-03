using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _3396_Minimum_Number_of_Operations_to_Make_Elements_in_Array_Distinct
    {
        public static int MinimumOperations(int[] nums)
        {
            //runtime 74%
            var set = new HashSet<int>();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (set.Contains(nums[i]))
                {
                    return (int)Math.Ceiling((i + 1) / 3m);
                }
                set.Add(nums[i]);
            }
            return 0;
            //runtiem 7%
            //var numList = nums.ToList();
            //var length = nums.Length;
            //var result = 0;

            //while (numList.Count != numList.Distinct().Count() && numList.Count > 0)
            //{
            //    if (numList.Count > 3)
            //        numList.RemoveRange(0, 3);
            //    else
            //        numList.Clear();
            //    result++;
            //}

            //return result;
        }
    }
}
