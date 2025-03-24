using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0520_Detect_Capital
    {
        public bool DetectCapitalUse(string word)
        {
            //runtime 49%
            return word.All(char.IsUpper) || word.Skip(1).All(char.IsLower);

            //runtime 33%
            //var upper = 0;
            //var lower = 0;
            //foreach (var c in word)
            //{
            //    if (char.IsUpper(c))
            //    {
            //        upper++;
            //    }
            //    else
            //    {
            //        lower++;
            //    }
            //}
            //return upper == word.Length || lower == word.Length || (upper == 1 && char.IsUpper(word[0]));
        }
    }
}
