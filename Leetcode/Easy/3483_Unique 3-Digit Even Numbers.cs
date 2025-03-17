using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _3483_Unique_3_Digit_Even_Numbers
    {
        //runtime 100%
        //同2094
        public int TotalNumbers(int[] digits)
        {
            var result = new List<int>();
            var digit = new int[10];

            foreach (var d in digits)
            {
                digit[d]++;
            }

            var tmpDigit = new int[10];

            for (int i = 100; i < 1000; i += 2)
            {
                var one = i % 10;
                var ten = i % 100 / 10;
                var hundred = i / 100;

                tmpDigit[one]++;
                tmpDigit[ten]++;
                tmpDigit[hundred]++;

                if (tmpDigit[one] <= digit[one] && tmpDigit[ten] <= digit[ten] && tmpDigit[hundred] <= digit[hundred])
                {
                    result.Add(i);
                }

                tmpDigit[one] = 0;
                tmpDigit[ten] = 0;
                tmpDigit[hundred] = 0;
            }

            return result.Count;
        }
    }
}
