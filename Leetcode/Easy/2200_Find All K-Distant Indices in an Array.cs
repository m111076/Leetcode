using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2200_Find_All_K_Distant_Indices_in_an_Array
    {
        public IList<int> FindKDistantIndices(int[] nums, int key, int k)
        {
            //runtime 48%
            //time complexity O(nk)
            //space complexity O(n)
            var keyIdx = new List<int>();
            var result = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == key)
                    keyIdx.Add(i);
            }

            var idx = 0;

            foreach (int i in keyIdx)
            {
                for (var j = i - k; j <= i + k; j++)
                {
                    if (j < 0)
                        continue;
                    if (j >= nums.Length)
                        break;
                    result.Add(j);
                }
            }


            return result.ToList();
        }
    }
}
