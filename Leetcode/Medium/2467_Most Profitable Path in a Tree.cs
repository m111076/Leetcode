using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _2467_Most_Profitable_Path_in_a_Tree
    {
        public int MostProfitablePath(int[][] edges, int bob, int[] amount)
        {
            int n = amount.Length;
            List<int>[] tree = new List<int>[n];
            for (int i = 0; i < n; i++) tree[i] = new List<int>();

            foreach (var edge in edges)
            {
                tree[edge[0]].Add(edge[1]);
                tree[edge[1]].Add(edge[0]);
            }

            int[] bobDist = new int[n];
            Array.Fill(bobDist, int.MaxValue);
            CheckBobPath(tree, bob, -1, 0, bobDist);

            return CheckAliceProfit(tree, 0, -1, 0, bobDist, amount);
        }
        private bool CheckBobPath(List<int>[] tree, int node, int parent, int depth, int[] bobDist)
        {
            bobDist[node] = depth;
            if (node == 0) return true;

            foreach (var neighbor in tree[node])
            {
                if (neighbor == parent) continue;
                if (CheckBobPath(tree, neighbor, node, depth + 1, bobDist)) return true;
            }

            bobDist[node] = int.MaxValue; // Reset if not on Bob’s path
            return false;
        }

        private int CheckAliceProfit(List<int>[] tree, int node, int parent, int depth, int[] bobDist, int[] amount)
        {
            int currentAmount = amount[node];

            if (bobDist[node] != int.MaxValue)
            {
                if (bobDist[node] > depth)
                {
                    // Bob reaches later, Alice takes full amount
                }
                else if (bobDist[node] == depth)
                {
                    // Alice and Bob share
                    currentAmount /= 2;
                }
                else
                {
                    // Bob reaches first, Alice gets nothing
                    currentAmount = 0;
                }
            }

            int maxProfit = int.MinValue;
            bool isLeaf = true;

            foreach (var neighbor in tree[node])
            {
                if (neighbor == parent) continue;
                isLeaf = false;
                maxProfit = Math.Max(maxProfit, CheckAliceProfit(tree, neighbor, node, depth + 1, bobDist, amount));
            }

            return currentAmount + (isLeaf ? 0 : maxProfit);
        }
    }
}
