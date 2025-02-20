using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0205_Isomorphic_Strings
    {
        public bool IsIsomorphic(string s, string t)
        {
            ////runtime 83% memory 58%
            //var sDic = new Dictionary<char, char>();
            //var tDic = new Dictionary<char, char>();
            //var l = s.Length;

            //for (var i = 0; i < l; i++)
            //{
            //    if (sDic.TryGetValue(s[i], out Char tValue))
            //    {
            //        if (t[i] != tValue) return false;
            //    }
            //    else
            //    {
            //        sDic.Add(s[i], t[i]);

            //        if (tDic.TryGetValue(t[i], out Char sValue))
            //        {
            //            if (s[i] != sValue) return false;
            //        }
            //        tDic.Add(t[i], s[i]);
            //    }
            //}
            //return true;


            //runtime 100% memory 28%
            var sChars = new int[128];
            var tChars = new int[128];
            var l = s.Length;

            for (var i = 0; i < l; i++)
            {
                var sChar = s[i];
                var tChar = t[i];

                if (sChars[sChar] == 0 && tChars[tChar] == 0)
                {
                    sChars[sChar] = tChar;
                    tChars[tChar] = sChar;
                }
                if (sChars[sChar] != tChar || tChars[tChar] != sChar)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
