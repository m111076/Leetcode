using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _3493_Properties_Graph
    {
        public int NumberOfComponents(int[][] properties, int k)
        {
            int n = properties.Length;
            UnionFind uf = new UnionFind(n);

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (intersect(properties[i], properties[j]) >= k)
                    {
                        uf.Union(i, j);
                    }
                }
            }

            return uf.CountComponents();
        }
        private int intersect(int[] a, int[] b)
        {
            HashSet<int> setA = new HashSet<int>(a);
            HashSet<int> setB = new HashSet<int>(b);
            setA.IntersectWith(setB);
            return setA.Count;
        }
        public class UnionFind
        {
            private int[] parent;
            private int[] rank;
            private int count;

            public UnionFind(int n)
            {
                parent = new int[n];
                rank = new int[n];
                count = n;

                for (int i = 0; i < n; i++)
                {
                    parent[i] = i;
                    rank[i] = 1;
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
                int rootX = Find(x);
                int rootY = Find(y);
                if (rootX != rootY)
                {
                    if (rank[rootX] > rank[rootY])
                    {
                        parent[rootY] = rootX;
                    }
                    else if (rank[rootX] < rank[rootY])
                    {
                        parent[rootX] = rootY;
                    }
                    else
                    {
                        parent[rootY] = rootX;
                        rank[rootX]++;
                    }
                    count--;
                }
            }

            public int CountComponents()
            {
                HashSet<int> uniqueRoots = new HashSet<int>();
                for (int i = 0; i < parent.Length; i++)
                {
                    uniqueRoots.Add(Find(i));
                }
                return uniqueRoots.Count;
            }
        }
    }
}
