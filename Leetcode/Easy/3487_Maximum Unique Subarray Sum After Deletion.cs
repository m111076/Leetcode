using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _3487_Maximum_Unique_Subarray_Sum_After_Deletion
    {
        //runtime 100%
        //全都小於0的狀況要考慮
        public int MaxSum(int[] nums)
        {
            var tmp = new HashSet<int>();
            var tmpSum = 0;
            var singleMax = int.MinValue;
            var max = int.MinValue;

            foreach (var num in nums)
            {
                if (num > 0 && !tmp.Contains(num))
                {
                    tmp.Add(num);
                    tmpSum += num;
                }
                singleMax = Math.Max(singleMax, num);
                max = Math.Max(max, tmpSum);
            }

            return singleMax <= 0 ? singleMax : max;
        }
    }
}
