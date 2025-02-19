using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0145_Binary_Tree_Postorder_Traversal
    {
        //postorder left right mid
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null) return new List<int>();

            var result = new List<int>();
            ReadNode(root.left);
            ReadNode(root.right);
            result.Add(root.val);

            return result;

            void ReadNode(TreeNode iRoot)
            {
                if (iRoot == null) return;
                ReadNode(iRoot.left);
                ReadNode(iRoot.right);
                result.Add(iRoot.val);
            }

        }
    }
}
