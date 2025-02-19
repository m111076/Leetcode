using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public static class _111_Minimum_Depth_of_Binary_Tree
    {
        public static int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((root, 1));

            while (queue.Count > 0)
            {
                var (node, depth) = queue.Dequeue();

                if (node.left == null && node.right == null)
                {
                    return depth;
                }

                if (node.left != null)
                {
                    queue.Enqueue((node.left, depth + 1));
                }

                if (node.right != null)
                {
                    queue.Enqueue((node.right, depth + 1));
                }
            }

            return 0;


            //if (root == null) return 0;

            //if (root.left == null && root.right == null) return 1;

            //if (root.left == null)
            //    return MinDepth(root.right) + 1;

            //if (root.right == null)
            //    return MinDepth(root.left) + 1;

            //return Math.Min(MinDepth(root.right), MinDepth(root.left)) + 1;

            //if (root == null) return 0;

            //if (root.left == null)
            //{
            //    return CountHeight(root.right) + 1;

            //}
            //else if (root.right == null)
            //{
            //    return CountHeight(root.left) + 1;
            //}
            //else
            //{
            //    return Math.Min(CountHeight(root.left), CountHeight(root.right)) + 1;
            //}
        }

        //public static int CountHeight(TreeNode iNode)
        //{
        //    if (iNode == null) return 0;

        //    return 1 + Math.Max(CountHeight(iNode.left), CountHeight(iNode.right));

        //}

    }
}
