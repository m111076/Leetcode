using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0383_Ransom_Note
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            //runtime 81%
            //同350
            var ransomDic = new Dictionary<char, int>();

            foreach (char c in ransomNote)
            {
                if (!ransomDic.ContainsKey(c))
                    ransomDic.Add(c, 1);
                else
                    ransomDic[c]++;
            }

            foreach (char c in magazine)
            {
                if (ransomDic.ContainsKey(c))
                {
                    if (--ransomDic[c] == 0)
                        ransomDic.Remove(c);
                }
                if (ransomDic.Count == 0)
                    return true;
            }
            return false;
        }
    }
}
