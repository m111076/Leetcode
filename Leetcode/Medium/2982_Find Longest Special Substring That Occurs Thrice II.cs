using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2982_Find_Longest_Special_Substring_That_Occurs_Thrice_II
    {
        //runtime 80%
        //time complexity O(nlogn)
        //space complexity O(n)
        //字串的選擇方法為重點
        //可以有三種選法
        //1.最長的字串L1-2取三次
        //2.比較L1-1和次長L2，以較小的作為選取的值(L1=L2和L1>L2兩種情形)
        //3.L3
        //為避免只有一個字串的狀況可以在後面補2個0
        public int MaximumLength(string s)
        {
            var charArray = new List<int>[26];
            var cnt = 0;

            for (var i = 0; i < 26; i++)
                charArray[i] = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                cnt++;

                if (i == s.Length - 1 || s[i] != s[i + 1])
                {
                    charArray[s[i] - 'a'].Add(cnt);
                    cnt = 0;
                }
            }

            var result = 0;

            foreach (var nums in charArray)
            {
                if (nums.Count == 0)
                    continue;

                nums.Sort((a, b) => b.CompareTo(a));
                nums.AddRange(new List<int>() { 0, 0, });

                result = Math.Max(Math.Max(result, nums[0] - 2), Math.Max(Math.Min(nums[0] - 1, nums[1]), nums[2]));
            }

            return result == 0 ? -1 : result;
        }
    }
}
