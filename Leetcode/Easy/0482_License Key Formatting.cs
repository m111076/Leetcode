using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0482_License_Key_Formatting
    {
        public string LicenseKeyFormatting(string s, int k)
        {
            //85%
            var tmp = s.Replace("-", string.Empty).ToUpper();

            if (tmp.Length == 0) return string.Empty;

            var left = tmp.Length % k;
            var result = new StringBuilder();

            if (left != 0)
            {
                result.Append(tmp.Substring(0, left));
                result.Append("-");
            }

            for (var i = left; i < tmp.Length; i += k)
            {
                result.Append(tmp.Substring(i, k));
                result.Append("-");
            }

            return result.ToString().Substring(0, result.Length - 1);

            //runtime 5%
            //var length = s.Length;
            //var cnt = 0;
            //var result = string.Empty;

            //for (var i = length - 1; i >= 0; i--)
            //{
            //    if (s[i] != '-')
            //    {
            //        if (cnt == k)
            //        {
            //            result = "-" + result;
            //            cnt = 0;
            //        }

            //        result = s[i] + result;
            //        cnt++;
            //    }
            //}

            //return result.ToUpper();
        }
    }
}
