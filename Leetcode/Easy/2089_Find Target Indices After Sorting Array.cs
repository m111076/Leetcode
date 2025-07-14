using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _2089_Find_Target_Indices_After_Sorting_Array
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        public IList<int> TargetIndices(int[] nums, int target)
        {
            var lessCnt = 0;
            var targetCnt = 0;

            foreach (var num in nums)
            {
                if (num < target) lessCnt++;
                else if (num == target) targetCnt++;
            }

            var result = new List<int>();

            for(var i = 0; i < targetCnt; i++)
            {
                result.Add(lessCnt + i);
            }

            return result;
        }
    }
}
