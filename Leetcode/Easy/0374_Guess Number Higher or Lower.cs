using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0374_Guess_Number_Higher_or_Lower
    {
        public int GuessNumber(int n)
        {
            //runtime 10%
            //min + (max - min) / 2 速度比 ( min + max )/2 快
            var min = 1;
            var max = n;
            var mid = n / 2;

            while (min <= max)
            {
                mid = min + (max - min) / 2;

                var result = guess(mid);
                if (result == 0)
                {
                    return mid;
                }
                else if (result == 1)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return mid;
        }

        public int guess(int num)
        {
            return -1;
        }
    }
}
