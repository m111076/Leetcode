using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Hard
{
    public class _2999_Count_the_Number_of_Powerful_Integers
    {
        //runtime 73%
        //time complexity O(n)
        //space complexity O(1)
        public long NumberOfPowerfulInt(long start, long finish, int limit, string s)
        {
            var strStart = (start - 1).ToString();
            var strFinish = finish.ToString();

            return CountPowerful(strFinish, s, limit) - CountPowerful(strStart, s, limit);
        }

        private long CountPowerful(string iStart, string iSuffix, int iLimit)
        {
            if (iStart.Length < iSuffix.Length)
                return 0;

            if (iStart.Length == iSuffix.Length)
                return string.Compare(iStart, iSuffix) >= 0 ? 1 : 0;

            var suffix = iStart.Substring(iStart.Length - iSuffix.Length);
            var length = iStart.Length - iSuffix.Length;
            var result = 0L;

            for (var i = 0; i < length; i++)
            {
                var target = iStart[i] - '0';
                if (iLimit < target)
                {
                    result += (long)Math.Pow(iLimit + 1, length - i);
                    return result;
                }

                result += (long)target * (long)Math.Pow(iLimit + 1, length - 1 - i);
            }

            if (string.Compare(suffix, iSuffix) >= 0)
                result++;

            return result;
        }
    }
}
