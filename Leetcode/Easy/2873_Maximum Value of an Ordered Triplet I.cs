using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2873_Maximum_Value_of_an_Ordered_Triplet_I
    {
        //runtime 100%
        public long MaximumTripletValue(int[] nums)
        {
            long result = 0;
            long maxSub = 0;
            long max = 0;

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
