using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0541_Reverse_String_II
    {
        public string ReverseStr(string s, int k)
        {
            //runtime 100%
            //可以避免substring的效能問題
            var tmp = s.ToCharArray();

            for (var i = 0; i < s.Length; i += 2 * k)
            {
                var end = Math.Min(i + k, s.Length);

                Array.Reverse(tmp, i, end - i);
            }
            return new string(tmp);

            //runtime 19%
            //var idx = 0;

            //while (idx < s.Length)
            //{
            //    var end = Math.Min(idx + k, s.Length);
            //    var tmp = s.Substring(idx, end - idx).ToCharArray();
            //    Array.Reverse(tmp);
            //    s = s.Remove(idx, end - idx).Insert(idx, new string(tmp));
            //    idx += 2 * k;
            //}

            //return s;
        }
    }
}

