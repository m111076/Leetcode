using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0171_Excel_Sheet_Column_Number
    {
        public int TitleToNumber(string columnTitle)
        {
            //正面算就好不用多此一舉= =
            int result = 0;
            foreach (char c in columnTitle)
            {
                result = result * 26 + (c - 'A' + 1);
            }
            return result;


            //runtime 13%
            //var result = 0;
            //var cnt = 0;

            //foreach (var c in columnTitle.Reverse())
            //{
            //    result += (c - 'A' + 1) * (int)Math.Pow(26, cnt);
            //    cnt++;
            //}
            //return result;
        }
    }
}
