using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leetcode.BC
{
    public class _250301_Q4_Permutations_IV
    {
        //private static List<int[]> ans = new List<int[]>();
        private static Dictionary<int, int[]> ans_dic = new Dictionary<int, int[]>();
        private static bool[] vis;
        private static int[] t;
        private static int nn;
        private static int cnt = 0;
        public static int[] Permute(int n, long k)
        {
            nn = n;
            t = new int[n];
            vis = new bool[n + 1];
            Dfs(0);
            if (k <= ans_dic.Count)
                return ans_dic[(int)k].ToArray();
            else
                return new int[0];
        }
        private static void Dfs(int i)
        {
            if (i >= nn)
            {
                ans_dic.Add(++cnt,(int[])t.Clone());
                return;
            }
            for (int j = 1; j <= nn; ++j)
            {
                if (!vis[j] && (i == 0 || t[i - 1] % 2 != j % 2))
                {
                    vis[j] = true;
                    t[i] = j;
                    Dfs(i + 1);
                    vis[j] = false;
                }
            }
        }
    }
}
