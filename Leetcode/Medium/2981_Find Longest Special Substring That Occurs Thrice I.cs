using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    //runtime 81%
    //time complexity: O(nlogn)
    //space complexity: O(n)
    //二分搜尋法搭配滑動視窗
    internal class _2981_Find_Longest_Special_Substring_That_Occurs_Thrice_I
    {
        public int MaximumLength(string s)
        {
            var n = s.Length;
            var left = 1;
            var right = n;

            if (!Helper(s, n, left)) return -1;

            while (left + 1 < right)
            {
                var mid = (left + right) / 2;
                if (Helper(s, n, mid)) left = mid;
                else right = mid;
            }

            return left;
        }

        private bool Helper(string s, int n, int x)
        {
            var cnt = new int[26];
            var p = 0;

            for (int i = 0; i < n; i++)
            {
                while (s[p] != s[i]) p++;
                if (i - p + 1 >= x) cnt[s[i] - 'a']++;
                if (cnt[s[i] - 'a'] > 2) return true;
            }

            return false;
        }
    }
}
