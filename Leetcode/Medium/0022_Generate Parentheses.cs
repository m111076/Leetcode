using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0022_Generate_Parentheses
    {
        //runtime 100%
        //time complexity O(4^n/sqrt(n))
        //space complexity O(n) 大家共用一個char[]
        //毫無技巧全是DFS，空間複雜度可以節省
        private List<string> Results = new List<string>();
        private char[] tmpResult;

        public IList<string> GenerateParenthesis(int n)
        {
            tmpResult = new char[n * 2];

            if (n > 0)
                DFS(0, 0);

            return Results;
        }

        private void DFS(int leftUse, int idx)
        {
            if (idx == tmpResult.Length)
            {
                Results.Add(new string(tmpResult));
                return;
            }
            if (leftUse < tmpResult.Length / 2)
            {
                tmpResult[idx] = '(';
                DFS(leftUse + 1, idx + 1);
            }
            if (leftUse > idx - leftUse)
            {
                tmpResult[idx] = ')';
                DFS(leftUse, idx + 1);
            }
        }
    }
}
