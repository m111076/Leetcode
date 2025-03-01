using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BC
{
    public class _250301_Q2_Find_the_Number_of_Copy_Arrays
    {
        public int CountArrays(int[] original, int[][] bounds)
        {
            var low = bounds[0][0];
            var high = bounds[0][1];
            var ans = high - low + 1;
            for (int i = 1; i < original.Length; ++i)
            {
                int diff = original[i] - original[i - 1];
                low = Math.Max(low + diff, bounds[i][0]);
                high = Math.Min(high + diff, bounds[i][1]);
                ans = Math.Min(ans, high - low + 1);
            }
            return ans < 0 ? 0 : ans;
        }
    }
}
