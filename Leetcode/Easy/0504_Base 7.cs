using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0504_Base_7
    {
        //runtime:100%
        //7進位
        public string ConvertToBase7(int num)
        {
            if (num == 0) return "0";

            var result = new StringBuilder();
            var isNegative = num < 0;
            num = Math.Abs(num);

            while(num > 0)
            {
                result.Insert(0, num % 7);
                num /= 7;
            }

            if (isNegative)
            {
                result.Insert(0, '-');
            }

            return result.ToString();
        }
    }
}
