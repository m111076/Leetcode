using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public static class _1718_Construct_the_Lexicographically_Largest_Valid_Sequence
    {
        public static int[] ConstructDistancedSequence(int n)
        {
            var ans = new int[2 * n - 1];
            var cand = new bool[n + 1];
            dfs(cand, ans, 0);
            return ans;
        }

        static bool dfs(bool[] cand, int[] ans, int pos)
        {
            if (pos == ans.Length)
                return true;
            // 之前已經設定值過了，直接向下遞迴
            if (ans[pos] > 0)
                return dfs(cand, ans, pos + 1);

            for (int i = cand.Length - 1; i >= 1; i--)
            {
                if (!cand[i])
                {
                    cand[i] = true;
                    ans[pos] = i;
                    if (i == 1)
                    {  // 1 只有一個可以任意放，不須檢查
                        if (dfs(cand, ans, pos + 1))
                            return true;
                        // 2~n有兩個，檢查另外一個位置是否在陣列長度內以及還沒有被其他數值放入
                    }
                    else if (i + pos < ans.Length && ans[i + pos] == 0)
                    {
                        ans[i + pos] = i;
                        if (dfs(cand, ans, pos + 1)) return true;
                        ans[i + pos] = 0;
                    }
                    // 需清除為初始值
                    ans[pos] = 0;
                    cand[i] = false;
                }
            }
            return false;
        }
    }
}
