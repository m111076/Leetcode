using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2062_Count_Vowel_Substrings_of_a_String
    {
        public static int CountVowelSubstrings(string word)
        {
            //runtime 92%
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var map = new Dictionary<char, int>();
            var length = word.Length;
            var result = 0;
            var conIdx = -1;

            for (var i = 0; i < length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    if (map.ContainsKey(word[i]))
                        map[word[i]] = i;
                    else
                        map.Add(word[i], i);
                }
                else
                {
                    conIdx = i;
                }

                if (map.Count == 5)
                {
                    result += Math.Max(map.Min(s => s.Value) - conIdx, 0);
                }
            }
            return result;

        }
    }
}
