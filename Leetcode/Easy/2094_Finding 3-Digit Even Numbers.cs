using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _2094_Finding_3_Digit_Even_Numbers
    {
        //runtime 100%
        //先記錄 intput 0-9的數量
        //之後從100算到999
        //數量有符合input的偶數加入result
        public static int[] FindEvenNumbers(int[] digits)
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

            return result.ToArray();
        }
    }
}
