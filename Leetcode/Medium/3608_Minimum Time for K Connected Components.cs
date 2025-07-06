using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3608_Minimum_Time_for_K_Connected_Components
    {
        private class UnionFind
        {

            public int[] parent;

            public UnionFind(int c)
            {
                parent = new int[c];
                for (var i = 0; i < c; i++)
                {
                    parent[i] = i;
                }
            }

            public int Find(int x)
            {
                if (parent[x] != x)
                {
                    parent[x] = Find(parent[x]);
                }
                return parent[x];
            }

            public void Union(int x, int y)
            {
                var px = Find(x);
                var py = Find(y);

                if (px != py)
                {
                    if (px < py)
                        parent[py] = px;
                    else
                        parent[px] = py;
                }
            }
        }

        public int MinTime(int n, int[][] edges, int k)
        {
            var left = 0;
            var right = 0;

            foreach (var edge in edges)
            {
                right = Math.Max(right, edge[2]);
            }

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (Check(n, edges, mid, k))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return right;
        }

        private bool Check(int n, int[][] edges, int timeLimit, int k)
        {
            var uf = new UnionFind(n);
                
            foreach (var edge in edges)
            {
                if (edge[2] > timeLimit)
                {
                    uf.Union(edge[0], edge[1]);
                }
            }

            var cnt = 0;

            for (int i = 0; i < uf.parent.Length; i++)
            {
                if (uf.parent[i] == i)
                    cnt++;
            }

            return cnt >= k;
        }
    }
}
