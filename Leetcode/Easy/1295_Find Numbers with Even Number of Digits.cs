using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1295_Find_Numbers_with_Even_Number_of_Digits
    {
        public int FindNumbers(int[] nums)
        {
            //轉乘string計算長度
            //runtime 100%
            //time complexity O(n)
            //space complexity O(1)
            var result = 0;

            foreach (var num in nums)
            {
                var digits = num.ToString().Length;
                if ((digits & 1) == 0)
                {
                    result++;
                }
            }

            return result;
            //runtime 58%
            //time complexity O(n)
            //space complexity O(1)
            //var result = 0;

            //foreach (var num in nums)
            //{
            //    var digits = 0;
            //    var n = num;
            //    while (n > 0)
            //    {
            //        n /= 10;
            //        digits++;
            //    }
            //    if ((digits & 1) == 0)
            //    {
            //        result++;
            //    }
            //}
            //return result;
        }
    }
}
