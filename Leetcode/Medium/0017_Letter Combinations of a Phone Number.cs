using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0017_Letter_Combinations_of_a_Phone_Number
    {
        //runtime 100%
        //time complexity O(n*m^n) n=digits.length ,m 最多為4
        //space complexity O(n*m^n)
        private Dictionary<char, string> Digital2Letter = new()
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };
        private List<string> Results = new List<string>();

        public IList<string> LetterCombinations(string digits)
        {
            if (digits != string.Empty)
                DFS(digits, string.Empty, 0);

            return Results;
        }

        private void DFS(string digits, string currentStr, int idx)
        {
            var digit = digits[idx];
            foreach (var letter in Digital2Letter[digit])
            {
                var newStr = currentStr + letter;
                if (idx == digits.Length - 1)
                {
                    Results.Add(newStr);
                }
                else
                {
                    DFS(digits, newStr, idx + 1);
                }
            }
        }
    }
}
