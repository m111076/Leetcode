using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0441_Arranging_Coins
    {
        public int ArrangeCoins(int n)
        {
            //runtime 100%
            //二分搜尋法
            long left = 0;
            long right = n;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var coinCnt = (mid + 1) * mid / 2;

                if (coinCnt == n)
                    return (int)mid;
                if (coinCnt > n)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return (int)right;

            //runtime16%
            //var result = 0;
            //var stair = 1;

            //while (n >= 0)
            //{
            //    n -= stair;
            //    if (n > 0)
            //        result++;
            //    stair++;
            //}

            //return result;
        }
    }
}
