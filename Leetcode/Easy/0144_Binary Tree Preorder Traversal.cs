using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0144_Binary_Tree_Preorder_Traversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            //Preorder mid left right
            if (root == null) return new List<int>();

            var result = new List<int>();
            result.Add(root.val);
            ReadNode(root.left);
            ReadNode(root.right);

            return result;

            void ReadNode(TreeNode iRoot)
            {
                if (iRoot == null) return;
                result.Add(iRoot.val);
                ReadNode(iRoot.left);
                ReadNode(iRoot.right);
            }
        }
    }
}
