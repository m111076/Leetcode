using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _66_Plus_One
    {
        public static int[] PlusOne(int[] digits)
        {
            var last = digits.Last() + 1;
            var lastIdx = digits.Count() - 1;
            digits[lastIdx] = last;
            var tempDigit = new int[digits.Count() + 1];

            while (10 <= last)
            {
                if (0 <= lastIdx - 1)
                {
                    digits[lastIdx] -= 10;
                    digits[--lastIdx] = digits[lastIdx] + 1;
                    last = digits[lastIdx];
                }
                else
                {
                    tempDigit[0] = 1;
                    digits[lastIdx] -= 10;

                    for (var i = 0; i < digits.Count(); i++)
                    {
                        tempDigit[i + 1] = digits[i];
                    }
                    last = 1;
                    return tempDigit;
                }
            }
            return digits;
        }
    }
}
