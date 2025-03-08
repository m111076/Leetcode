using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0387_First_Unique_Character_in_a_String
    {
        public int FirstUniqChar(string s)
        {
            //runtime 53%
            var cDic = new Dictionary<char, int>();

            foreach (var c in s)
            {
                if (cDic.ContainsKey(c))
                    cDic[c]++;
                else
                    cDic.Add(c, 1);
            }

            for (var i = 0; i < s.Length; i++)
            {
                if (cDic[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
