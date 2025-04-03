using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2874_Maximum_Value_of_an_Ordered_Triplet_II
    {
        public long MaximumTripletValue(int[] nums)
        {
            var result = 0L;
            var maxSub = 0L;
            var max = 0;

            foreach (var num in nums)
            {
                result = Math.Max(result, maxSub * num);
                maxSub = Math.Max(maxSub, max - num);
                max = Math.Max(max, num);
            }

            return result;
        }
    }
}
