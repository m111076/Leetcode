using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3522_Calculate_Score_After_Performing_Instructions
    {
        //runtime 46%
        //time complexity O(n)
        //space complexity O(n)
        public long CalculateScore(string[] instructions, int[] values)
        {
            var result = 0L;
            var idx = 0;
            var check = new HashSet<int>();

            while (idx < instructions.Length && idx >= 0 && !check.Contains(idx))
            {
                check.Add(idx);

                if (instructions[idx] == "add")
                {
                    result += values[idx++];
                }
                else
                {
                    idx += values[idx];
                }
            }

            return result;
        }
    }
}
