using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _3136_Valid_Word
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public bool IsValid(string word)
        {
            if (word.Length < 3)
                return false;

            var containVowel = false;
            var containConsonant = false;

            foreach (var c in word)
            {
                if (!char.IsLetterOrDigit(c))
                    return false;
                if (char.IsDigit(c))
                    continue;
                else if ("aeiouAEIOU".IndexOf(c) >= 0)
                    containVowel = true;
                else
                    containConsonant = true;
            }

            return containVowel && containConsonant;
        }
    }
}
