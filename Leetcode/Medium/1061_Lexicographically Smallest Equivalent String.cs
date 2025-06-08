using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    //runtime 100%
    //time complexity O(n)
    //space complexity O(1)
    //並查集
    internal class _1061_Lexicographically_Smallest_Equivalent_String
    {
        private int[] Chars = new int[26];

        public string SmallestEquivalentString(string s1, string s2, string baseStr)
        {
            for (int i = 0; i < 26; i++)
            {
                Chars[i] = i;
            }

            for (int i = 0; i < s1.Length; i++)
            {
                Union(s1[i] - 'a', s2[i] - 'a');
            }

            var result = new StringBuilder();
            foreach (char ch in baseStr)
            {
                var rep = Find(ch - 'a');
                result.Append((char)(rep + 'a'));
            }

            return result.ToString();
        }

        private int Find(int x)
        {
            if (Chars[x] != x)
            {
                Chars[x] = Find(Chars[x]);
            }
            return Chars[x];
        }

        private void Union(int a, int b)
        {
            var rootA = Find(a);
            var rootB = Find(b);
            if (rootA < rootB)
            {
                Chars[rootB] = rootA;
            }
            else if (rootA > rootB)
            {
                Chars[rootA] = rootB;
            }
        }
    }
}
