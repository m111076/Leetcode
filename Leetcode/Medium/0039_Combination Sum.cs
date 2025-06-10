using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0039_Combination_Sum
    {
        //runtime 100%
        //time complexity O(2^n)
        //space complexityO(n)
        //DFS、共用一個list來節省空間，但要記得復原
        private List<IList<int>> Results = new List<IList<int>>();

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            DFS(candidates, 0, new List<int>(), target);

            return Results;
        }

        private void DFS(int[] candidates, int idx, List<int> tmpResult, int target)
        {
            if (target == 0)
            {
                Results.Add(new List<int>(tmpResult));
                return;
            }

            if (target < 0 || idx == candidates.Length)
                return;

            DFS(candidates, idx + 1, tmpResult, target);

            tmpResult.Add(candidates[idx]);
            DFS(candidates, idx, tmpResult, target - candidates[idx]);

            tmpResult.RemoveAt(tmpResult.Count - 1);
        }
    }
}
