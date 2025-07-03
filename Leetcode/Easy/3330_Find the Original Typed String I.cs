using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3330_Find_the_Original_Typed_String_I
    {
        public int PossibleStringCount(string word)
        {
            //runtime 68%
            //time complexity O(n)
            //sapce complexity O(1)
            var result = 1;
            var cur = word[0];
            var curCnt = 1;

            for (var i = 1; i < word.Length; i++)
            {
                if (cur == word[i])
                    curCnt++;
                else
                {
                    if (curCnt > 1)
                        result += curCnt - 1;

                    cur = word[i];
                    curCnt = 1;
                }
            }

            if (curCnt > 1)
                result += curCnt - 1;

            return result;
        }
    }
}
