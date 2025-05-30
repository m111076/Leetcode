using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _2359_Find_Closest_Node_to_Given_Two_Nodes
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        //首先先分別計算兩個node到edges中任意點的距離
        //無法到達的點就使用egdes的長度來代表，走訪過後就可將值改為與node的距離
        //若走訪過程中發現dis[i]起始值不為edges，代表出現環形結構
        public int ClosestMeetingNode(int[] edges, int node1, int node2)
        {
            var dis1 = CheckDistance(edges, node1);
            var dis2 = CheckDistance(edges, node2);

            int result = -1;
            var length = edges.Length;
            int minDis = length;

            for (int i = 0; i < length; i++)
            {
                var tmpDis = Math.Max(dis1[i], dis2[i]);
                if (tmpDis < minDis)
                {
                    minDis = tmpDis;
                    result = i;
                }
            }
            return result;
        }

        private int[] CheckDistance(int[] edges, int start)
        {
            var tmpDis = 0;
            var length = edges.Length;
            var dis = Enumerable.Repeat(length, length).ToArray();

            for (var x = start; x >= 0 && dis[x] == length; x = edges[x])
            {
                dis[x] = tmpDis++;
            }
            return dis;
        }
    }
}
