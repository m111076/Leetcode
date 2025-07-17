using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _1961_Check_If_String_Is_a_Prefix_of_Array
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public bool IsPrefixString(string s, string[] words)
        {
            var idx = 0;

            foreach (var word in words)
            {
                for (var i = 0; i < word.Length; i++)
                {
                    var c = word[i];

                    if (s[idx++] != c)
                    {
                        return false;
                    }

                    if (idx == s.Length)
                    {
                        if (i == word.Length - 1)
                            return true;
                        else
                            return false;
                    }

                }
            }

            return false;
        }
    }
}
