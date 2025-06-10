using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0046_Permutations
    {
        //runtime 84%
        //time complexity O(n!*n)
        //space complexity O(n)
        //DFS、共用list，用完要移除
        private List<IList<int>> Results = new List<IList<int>>();

        public IList<IList<int>> Permute(int[] nums)
        {
            var tmpResult = new List<int>();

            DFS(0, nums, tmpResult);

            return Results;
        }

        private void DFS(int idx, int[] nums, List<int> tmpResult)
        {
            if (idx == nums.Length)
            {
                Results.Add(new List<int>(tmpResult));
                return;
            }
            foreach (var num in nums)
            {
                if (tmpResult.Contains(num))
                    continue;
                tmpResult.Add(num);
                DFS(idx + 1, nums, tmpResult);
                tmpResult.RemoveAt(tmpResult.Count - 1);
            }
        }
    }
}
