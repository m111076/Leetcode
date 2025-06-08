using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    //runtime 75%
    //time complexity O(n)
    //space complexity O(n)
    internal class _0386_Lexicographical_Numbers
    {
        public IList<int> LexicalOrder(int n)
        {
            var result = new List<int>();

            for (int i = 1; i <= 9; i++)
            {
                DFS(i, n, result);
            }

            return result;
        }

        private void DFS(int current, int n, List<int> result)
        {
            if (current > n)
                return;

            result.Add(current);

            for (int i = 0; i < 10; i++)
            {
                int next = current * 10 + i;

                if (next <= n)
                {
                    DFS(next, n, result);
                }
                else
                    break;
            }
        }
    }
}
