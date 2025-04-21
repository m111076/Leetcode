using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2145_Count_the_Hidden_Sequences
    {
        //runtime 90%
        //time complexity O(n)
        //space complexity O(1)
        //紀錄運算過程中的最小值和最大值
        //將最小值平移置lower，之後判斷max同步平移後是否大於upper
        public int NumberOfArrays(int[] differences, int lower, int upper)
        {
            var min = 0L;
            var max = 0L;
            var tmpSum = 0L;

            foreach (var d in differences)
            {
                tmpSum += d;
                min = Math.Min(min, tmpSum);
                max = Math.Max(max, tmpSum);
            }

            var move = lower - min;
            max += move;

            return max > upper ? 0 : (int)(upper - max + 1);
        }
    }
}
