using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _0819_Most_Common_Word
    {
        //runtime 54%
        //time complexity O(nlogn)
        //space complexity O(n+m+b)
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var words = paragraph.ToLower().Split(new[] { ' ', '!', '?', '\'', ',', ';', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var bannedSet = new HashSet<string>(banned);
            var wordDIct = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var target = word.ToLower();
                if (!bannedSet.Contains(target))
                {
                    if (wordDIct.ContainsKey(target))
                    {
                        wordDIct[target]++;
                    }
                    else
                    {
                        wordDIct[target] = 1;
                    }
                }
            }
            return wordDIct.OrderByDescending(x => x.Value).FirstOrDefault().Key;
        }
    }
}
