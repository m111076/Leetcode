using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2843_Count_Symmetric_Integers
    {
        //runtime 35%
        //time complexity O(n*m)
        //space complexity O(1)
        public int CountSymmetricIntegers(int low, int high)
        {
            var result = 0;

            for (int i = low; i <= high; i++)
            {
                if (IsSymmetric(i))
                    result++;
            }

            return result;
        }

        private bool IsSymmetric(int iNum)
        {
            var str = iNum.ToString();

            if ((str.Length & 1) != 0)
                return false;

            var frontHalf = 0;
            var backHalf = 0;
            var half = str.Length / 2;

            for (var i = 0; i < half; i++)
            {
                frontHalf += str[i] - '0';
                backHalf += str[i + half] - '0';
            }

            return frontHalf == backHalf;
        }
    }
}
