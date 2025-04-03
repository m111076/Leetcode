using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _0889_Construct_Binary_Tree_from_Preorder_and_Postorder_Traversal
    {
        public int preIdx = 0;
        public int posIdx = 0;

        public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder)
        {
            TreeNode root = new TreeNode(preorder[preIdx++]);
            if (root.val != postorder[posIdx])
                root.left = ConstructFromPrePost(preorder, postorder);
            if (root.val != postorder[posIdx])
                root.right = ConstructFromPrePost(preorder, postorder);
            posIdx++;
            return root;
        }
    }
}
