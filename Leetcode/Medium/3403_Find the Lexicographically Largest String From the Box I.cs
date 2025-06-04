using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3403_Find_the_Lexicographically_Largest_String_From_the_Box_I
    {
        //runtime 57%
        //time complexity O(n)
        //space complexity O(1)
        //由於至少要分成n分，且不為空，因此除最大之外其他都為1
        //因此最大長度為w-(n-1)=>w-n+1
        public string AnswerString(string word, int numFriends)
        {
            if (numFriends == 1)
                return word;

            var maxLength = word.Length - numFriends + 1;
            var result = string.Empty;

            for (var i = 0; i < word.Length; i++)
            {
                var tmpResult = word.Substring(i, Math.Min(word.Length - i, maxLength));
                if (tmpResult.CompareTo(result) > 0)
                    result = tmpResult;
            }

            return result;
        }
    }
}
