using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3372_Maximize_the_Number_of_Target_Nodes_After_Connecting_Trees_I
    {
        //runtime 100%
        //time complexity O(e1^2+e2^2)
        //space complexity O(e1+e2)
        //首先要先將邊轉為串列
        //然後分別透過透過DFS找求出滿足條件的最大值
        //在e1上與e2對接的點一定是i，因為接在其他點一定會使e2上的點到i的距離差長
        public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k)
        {
            var result = new int[edges1.Length + 1];
            var max2 = 0;

            if (k > 0)
            {
                var tree2 = CreateTree(edges2);
                for (int i = 0; i < edges2.Length + 1; i++)
                {
                    max2 = Math.Max(max2, DFS(tree2, i, -1, 0, k - 1));
                }
            }

            var tree1 = CreateTree(edges1);

            for (int i = 0; i < edges1.Length+1; i++)
            {
                result[i] = max2 + DFS(tree1, i, -1, 0, k);
            }

            return result;
        }

        private int DFS(List<int>[] iTree, int iCurrentNode, int iFatherNode, int iDistance, int iLimitD)
        {
            if (iDistance > iLimitD)
                return 0;

            var cnt = 1;
            foreach (var nei in iTree[iCurrentNode])
            {
                if (nei != iFatherNode)
                    cnt += DFS(iTree, nei, iCurrentNode, iDistance + 1, iLimitD);
            }

            return cnt;
        }

        private List<int>[] CreateTree(int[][] edges)
        {
            var g = new List<int>[edges.Length + 1];

            for (int i = 0; i < g.Length; i++)
            {
                g[i] = new List<int>();
            }

            foreach (var e in edges)
            {
                int x = e[0];
                int y = e[1];
                g[x].Add(y);
                g[y].Add(x);
            }

            return g;
        }
    }
}
