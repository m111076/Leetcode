using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0459_Repeated_Substring_Pattern
    {
        public static bool RepeatedSubstringPattern(string s)
        {
            //runtime 100%
            //special
            var ss = s + s;
            return ss.Substring(1, ss.Length - 2).Contains(s);


            //runtime 6%
            //增加pattern長度比對
            //var length = s.Length;
            //var half = length / 2;

            //for (var i = 1; i <= half; i++)
            //{
            //    if (length % i == 0)
            //    {
            //        var times = length / i;
            //        var pattern = s.Substring(0, i);
            //        var target = string.Empty;

            //        for (var t = 0; t < times; t++)
            //        {
            //            target += pattern;
            //        }

            //        if (s == target)
            //            return true;
            //    }
            //}
            //return false;
        }
    }
}
