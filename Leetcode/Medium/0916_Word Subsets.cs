using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _0916_Word_Subsets
    {
        public IList<string> WordSubsets(string[] words1, string[] words2)
        {
            //runtime 42%
            //time complexity O(n * m)
            //space complexity O(n)
            var map = new Dictionary<int, int>();
            var result = new List<string>();

            foreach (var word in words2)
            {
                var temp = new int[26];
                foreach (var c in word)
                {
                    temp[c - 'a']++;
                }
                for (int i = 0; i < 26; i++)
                {
                    if (temp[i] > map.GetValueOrDefault(i))
                    {
                        map[i] = temp[i];
                    }
                }
            }

            foreach (var word in words1)
            {
                var temp = new int[26];
                foreach (var c in word)
                {
                    temp[c - 'a']++;
                }

                var isValid = true;

                for (int i = 0; i < 26; i++)
                {
                    if (temp[i] < map.GetValueOrDefault(i))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    result.Add(word);
                }
            }

            return result;
        }
    }
}
