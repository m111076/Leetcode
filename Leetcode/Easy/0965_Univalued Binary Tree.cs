using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    internal class _0965_Univalued_Binary_Tree
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)
        public bool IsUnivalTree(TreeNode root)
        {
            if (root.left == null && root.right == null) return true;

            var value = root.val;
            var q = new Queue<TreeNode>();
            q.Enqueue(root.left);
            q.Enqueue(root.right);

            while (q.Count > 0)
            {
                var node = q.Dequeue();
                if (node == null) continue;
                if (node.val != value) return false;
                q.Enqueue(node.left);
                q.Enqueue(node.right);
            }

            return true;
        }
    }
}
