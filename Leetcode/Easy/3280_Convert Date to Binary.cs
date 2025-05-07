using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal static class _3280_Convert_Date_to_Binary
    {
        //runtime 95%
        //time complexity O(n)
        //轉為N進位的方法要記一下
        public static string ConvertDateToBinary(string date)
        {
            var strs = date.Split('-');
            var result = string.Empty;

            foreach (var str in strs)
            {
                var tmp = string.Empty;
                var i = int.Parse(str);

                while (i > 0)
                {
                    tmp = (i % 2).ToString() + tmp;
                    i /= 2;
                }

                result += tmp + "-";
            }
            result = result.Remove(result.Length - 1, 1);

            return result;
        }
    }
}
