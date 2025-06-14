using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0763_Partition_Labels
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(1)
        //先記錄每個字母出現的最後位置
        //然後再遍歷字串，計算前綴字母出現的最後位置
        //如果當前位置等於前前綴字母出現的最後位置
        //則可以輸出字串長度
        public IList<int> PartitionLabels(string s)
        {
            var result = new List<int>();
            var lastIndex = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                lastIndex[s[i] - 'a'] = i;
            }

            var currentStart = 0;
            var currentEnd = 0;

            for (var i = 0; i < s.Length; i++)
            {
                currentEnd = Math.Max(currentEnd, lastIndex[s[i] - 'a']);

                if (i == currentEnd)
                {
                    result.Add(currentEnd - currentStart + 1);
                    currentStart = i + 1;
                }
            }

            return result;
        }
    }
}
