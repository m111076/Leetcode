using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0405_Convert_a_Number_to_Hexadecimal
    {
        public static string ToHex(int num)
        {
            //runtime 100%
            //16進為等於使用2進位最後4位來轉
            //所以每次轉完後將原數右移4位 然後繼續計算
            //>>>整串一起移動 >>移動時保持左邊的符號
            if (num == 0) return "0";

            var map = "0123456789abcdef";
            var result = string.Empty;

            while (num != 0)
            {
                result = map[num & 15].ToString() + result;
                num = num >> 4;
            }

            return result;
        }
    }
}
