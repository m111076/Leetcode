using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _3208_Alternating_Groups_II
    {
        public int NumberOfAlternatingGroups(int[] colors, int k)
        {
            //runtime 70%
            //將前k-1加入至colors尾端 使用silding window
            var newColors = new List<int>(colors);
            newColors.AddRange(colors[..(k - 1)]);
            var result = 0;
            var startIdx = 0;

            for (var i = 0; i < newColors.Count; i++)
            {
                if (i > 0 && newColors[i] == newColors[i - 1])
                    startIdx = i;

                if (i - startIdx + 1 >= k)
                    result++;
            }

            return result;
        }
    }
}
