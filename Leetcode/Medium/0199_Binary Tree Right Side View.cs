using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0199_Binary_Tree_Right_Side_View
    {
        private List<int> Result = new List<int>();
        //runtime 16%
        //time complexity O(n)
        //space complexity O(n)
        //彈藥處理的判斷較多，可以試用別的方法
        //public IList<int> RightSideView(TreeNode root)
        //{
        //    var queue = new Queue<(int Rank, TreeNode root)>();

        //    if (root == null)
        //        return Result;

        //    var currentRank = 1;
        //    queue.Enqueue((0, root));

        //    while (queue.Count > 0)
        //    {
        //        var set = queue.Dequeue();

        //        if (set.Rank != currentRank)
        //        {
        //            Result.Add(set.root.val);
        //            currentRank = set.Rank;
        //        }

        //        if (set.root.right != null)
        //        {
        //            queue.Enqueue((set.Rank + 1, set.root.right));
        //        }
        //        if (set.root.left != null)
        //        {
        //            queue.Enqueue((set.Rank + 1, set.root.left));
        //        }
        //    }

        //    return Result;
        //}
        //runtime 100%
        public IList<int> RightSideView(TreeNode root)
        {
            var queue = new Queue<TreeNode>();

            if (root == null)
                return Result;

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var cnt = queue.Count;
                for (var i = 0; i < cnt; i++)
                {
                    var node = queue.Dequeue();
                    if (i == cnt - 1)
                    {
                        Result.Add(node.val);
                    }
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }
            return Result;
        }
    }
}
