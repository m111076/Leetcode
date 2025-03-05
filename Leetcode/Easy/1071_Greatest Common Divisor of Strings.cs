using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _1071_Greatest_Common_Divisor_of_Strings
    {
        //runtime 100%
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
                return string.Empty;

            var length = GCD(str1.Length, str2.Length);
            return new string(str1.Substring(0, length));
        }
        //輾轉相除法
        private int GCD(int a, int b)
        {
            var t = 1;
            while (t != 0)
            {
                t = a % b;
                a = b;
                b = t;
            }
            return a;
        }
    }
}
