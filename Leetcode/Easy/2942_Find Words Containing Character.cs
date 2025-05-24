using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2942_Find_Words_Containing_Character
    {
        //runtime 37%
        //time complexity O(w*n)
        //space complexity O(w)
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            var result = new List<int>();

            for (var i = 0; i < words.Length; i++)
            {
                foreach (var c in words[i])
                {
                    if (c == x)
                    {
                        result.Add(i);
                        break;
                    }
                }
            }

            return result;
        }
    }
}
