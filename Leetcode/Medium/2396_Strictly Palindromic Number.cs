using Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2396_Strictly_Palindromic_Number
    {
        public bool IsStrictlyPalindromic(int n)
        {
            //runtime 29%
            //time complexity O(n*n)
            //space complexity O(1)
            for (int i = 2; i <= n - 2; i++)
            {
                var str = new StringBuilder();
                var target = n;

                while (target > 0)
                {
                    str.Append($"{target % i}");
                    target /= i;
                }

                if (!Check(str))
                    return false;
            }

            return true;
        }

        private bool Check(StringBuilder iTarget)
        {
            var half = iTarget.Length / 2;

            for (int i = 0; i < half; i++)
            {
                if (iTarget[i] != iTarget[iTarget.Length - 1 - i])
                    return false;
            }

            return true;

        }
    }
}
