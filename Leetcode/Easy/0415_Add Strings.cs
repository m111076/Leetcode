using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0415_Add_Strings
    {
        public static string AddStrings(string num1, string num2)
        {
            //runtime 40%
            var result = new StringBuilder();
            var carry = 0;

            for (int i = num1.Length - 1, j = num2.Length - 1; i >= 0 || j >= 0 || carry == 1; i--, j--)
            {
                var tmp1 = i < 0 ? 0 : num1[i] - '0';
                var tmp2 = j < 0 ? 0 : num2[j] - '0';

                result.Insert(0, (tmp1 + tmp2 + carry) % 10);
                carry = (tmp1 + tmp2 + carry) / 10;
            }

            return result.ToString();

            ////runtime 28%
            //var result = string.Empty;
            //var carry = 0;

            //for (int i = num1.Length - 1, j = num2.Length - 1; i >= 0 || j >= 0 || carry == 1; i--, j--)
            //{
            //    var tmp1 = i < 0 ? 0 : num1[i] - '0';
            //    var tmp2 = j < 0 ? 0 : num2[j] - '0';

            //    result = $"{(tmp1 + tmp2 + carry) % 10}" + result;
            //    //result.Append((tmp1 + tmp2 + carry) % 10);
            //    carry = (tmp1 + tmp2 + carry) / 10;
            //}

            //return result;
        }
    }
}
