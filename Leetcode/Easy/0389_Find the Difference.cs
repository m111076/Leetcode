using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0389_Find_the_Difference
    {
        public char FindTheDifference(string s, string t)
        {
            //runtime 100%
            //也可以用Dictionary做看看
            var result = 0;

            for (var i = 0; i < t.Length; i++)
            {
                result += t[i];
            }
            for (var i = 0; i < s.Length; i++)
            {
                result -= s[i];
            }

            return (char)result;
        }
    }
}
