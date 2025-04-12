using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _2309_Greatest_English_Letter_in_Upper_and_Lower_Case
    {
        public string GreatestLetter(string s)
        {
            //runtime 18%
            var letters = new int[128];
            foreach (var c in s)
            {
                letters[c]++;
            }

            for (var i = 'z'; i >= 'a'; i--)
            {
                if (letters[i] > 0 && letters[i - 'a' + 'A'] > 0)
                {
                    return ((char)(i - 'a' + 'A')).ToString();
                }
            }

            return "";

            //runtime 40%
            //可以再合併
            //time complexity O(n)
            //space complexity O(n)
            var set = new HashSet<int>();
            var contaiins = new HashSet<int>();
            var gap = 'a' - 'A';
            var result = 0;

            foreach (var c in s)
            {
                //upper
                if (c < 'a')
                {
                    if (set.Contains(c + gap))
                    {
                        if (!contaiins.Contains(c))
                        {
                            result = Math.Max(result, c);
                            contaiins.Add(c);
                        }
                    }
                }
                else
                {
                    if (set.Contains(c - gap))
                    {
                        if (!set.Contains(c))
                        {
                            result = Math.Max(result, c - gap);
                            contaiins.Add(c - gap);
                        }
                    }
                }

                set.Add(c);
            }

            return result != 0 ? ((char)result).ToString() : "";
        }
    }
}
