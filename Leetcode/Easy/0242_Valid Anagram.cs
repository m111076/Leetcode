using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0242_Valid_Anagram
    {
        public static bool IsAnagram(string s, string t)
        {
            //runtime54%
            if (s.Length != t.Length) return false;

            var charDic = new Dictionary<char, int>();

            //紀錄s使用字元數量
            foreach (var c in s)
            {
                if (!charDic.ContainsKey(c))
                    charDic.Add(c, 1);
                else
                    charDic[c]++;
            }

            //判斷使用數量
            foreach (var c in t)
            {
                if (!charDic.ContainsKey(c))
                    return false;
                charDic[c]--;
                if (charDic[c] < 0)
                    return false;
            }
            return true;
        }
    }
}
