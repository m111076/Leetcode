using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0078_Subsets
    {
        //runtime 100%
        //time complexity O(2^n)
        //space complexity O(n)
        //DFS
        private IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> Subsets(int[] nums)
        {
            DFS(nums, 0, new List<int>());

            return result;
        }

        private void DFS(int[] nums, int idx, List<int> tmpResult)
        {
            if (idx == nums.Length)
            {
                result.Add(new List<int>(tmpResult));
                return;
            }

            //不加
            DFS(nums, idx + 1, tmpResult);
            //加
            tmpResult.Add(nums[idx]);
            DFS(nums, idx + 1, tmpResult);
            tmpResult.RemoveAt(tmpResult.Count - 1);
        }
    }
}
