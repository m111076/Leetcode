using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2231_Largest_Number_After_Digit_Swaps_by_Parity
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public int LargestInteger(int num)
        {
            var digits = new int[10];
            var numStr = num.ToString();

            foreach (var c in numStr)
            {
                digits[c - '0']++;
            }

            var result = 0;
            var oddIdx = 9;
            var evenIdx = 8;

            foreach (var c in numStr)
            {
                result *= 10;

                var digit = c - '0';
                if (digit % 2 == 0)
                {
                    while (evenIdx >= 0 && digits[evenIdx] == 0)
                    {
                        evenIdx -= 2;
                    }
                    result += evenIdx;
                    digits[evenIdx]--;
                }
                else
                {
                    while (oddIdx >= 0 && digits[oddIdx] == 0)
                    {
                        oddIdx -= 2;
                    }
                    result += oddIdx;
                    digits[oddIdx]--;
                }
            }

            return result;
        }
    }
}
