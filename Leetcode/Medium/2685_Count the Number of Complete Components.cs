using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2685_Count_the_Number_of_Complete_Components
    {
        //runtime 59%
        //先透過union find將這些頂點分類
        //再透過分類後的頂點數量來計算是否為complete component
        //complete component的邊數為頂點數*(頂點數-1)/2
        //如果邊數等於頂點數*(頂點數-1)/2則為complete component
        //最後計算有幾個complete component
        //這題的關鍵在於如何將頂點分類
        //透過union find可以將頂點分類
        //union find的find方法可以找到頂點所屬的分類
        //union find的union方法可以將兩個頂點合併
        public int CountCompleteComponents(int n, int[][] edges)
        {
            var parent = new int[n];
            var rank = new int[n];
            var componentVertices = new Dictionary<int, HashSet<int>>();
            var componentEdges = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
            }

            foreach (var edge in edges)
            {
                Union(parent, rank, edge[0], edge[1]);
            }

            for (var i = 0; i < n; i++)
            {
                var root = Find(parent, i);
                if (!componentVertices.ContainsKey(root))
                {
                    componentVertices.Add(root, new HashSet<int>());
                    componentEdges.Add(root, 0);
                }
                componentVertices[root].Add(i);
            }

            foreach (var edge in edges)
            {
                var root = Find(parent, edge[0]);
                componentEdges[root]++;
            }

            var result = 0;
            foreach (var key in componentVertices.Keys)
            {
                var amountOfVertices = componentVertices[key].Count;
                var targetEdges = amountOfVertices * (amountOfVertices - 1) / 2;
                if (componentEdges[key] == targetEdges)
                {
                    result++;
                }
            }

            return result;
        }

        public int Find(int[] iParent, int iTarget)
        {
            if (iParent[iTarget] == iTarget)
                return iTarget;
            return iParent[iTarget] = Find(iParent, iParent[iTarget]);
        }

        public void Union(int[] iParent, int[] iRank, int iV1, int iV2)
        {
            int vertice1 = Find(iParent, iV1);
            int vertice2 = Find(iParent, iV2);
            if (vertice1 == vertice2) return;

            if (iRank[vertice1] < iRank[vertice2])
            {
                iParent[vertice1] = vertice2;
            }
            else if (iRank[vertice1] > iRank[vertice2])
            {
                iParent[vertice2] = vertice1;
            }
            else
            {
                iParent[vertice1] = vertice2;
                iRank[vertice2]++;
            }
        }
    }
}
