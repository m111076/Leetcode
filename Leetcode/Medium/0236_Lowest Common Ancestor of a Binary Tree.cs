using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0236_Lowest_Common_Ancestor_of_a_Binary_Tree
    {
        //runtime 96%
        //time complexity O(n)
        //space complexity O(n)
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
                return root;

            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);

            if (left != null && right != null)
                return root;

            return left ?? right;
        }
    }
}
