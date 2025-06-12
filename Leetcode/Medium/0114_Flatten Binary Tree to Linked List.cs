using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0114_Flatten_Binary_Tree_to_Linked_List
    {
        //runtime 100%
        //time complexity O(n)
        //space complexity O(n)/O(logn)=>極度不平衡與平衡
        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;

            Flatten(root.left);
            Flatten(root.right);

            var tmp = root.right;
            root.right = root.left;
            root.left = null;

            var current = root;
            while (current.right != null)
            {
                current = current.right;
            }
            current.right = tmp;
        }
    }
}
