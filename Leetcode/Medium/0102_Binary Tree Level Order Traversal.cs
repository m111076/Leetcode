using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0102_Binary_Tree_Level_Order_Traversal
    {
        //runtime 11%
        //time complexity O(n)
        //space complexity O(n)
        //用遞迴可以壓至logn
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();

            if (root == null)
                return result;

            var tmpResult = new List<int>();
            var rank = 0;
            var queue = new Queue<(int, TreeNode)>();

            queue.Enqueue((rank, root));

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.Item1 != rank)
                {
                    result.Add(new List<int>(tmpResult));
                    tmpResult.Clear();
                    rank = current.Item1;
                }

                if (current.Item2 == null)
                    continue;

                tmpResult.Add(current.Item2.val);

                queue.Enqueue((current.Item1 + 1, current.Item2.left));
                queue.Enqueue((current.Item1 + 1, current.Item2.right));
            }

            return result;
        }
    }
}
