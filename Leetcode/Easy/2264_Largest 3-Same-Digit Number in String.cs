using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2264_Largest_3_Same_Digit_Number_in_String
    {
        //runtime 84%
        //time space complexity O(n)
        //space complexity O(1) 
        public string LargestGoodInteger(string num)
        {
            var result = -1;
            for (var i = 0; i < num.Length - 2; i++)
            {
                if (num[i] == num[i + 1] && num[i] == num[i + 2])
                {
                    result = Math.Max(result, num[i] - '0');
                }
            }

            return result == -1 ? "" : new string((char)('0' + result), 3);
        }
    }
}
