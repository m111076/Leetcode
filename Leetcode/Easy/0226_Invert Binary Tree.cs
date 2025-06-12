using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0226_Invert_Binary_Tree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            //runtime 100% memory 38%
            //time complexity O(n)
            //space complexity 最壞O(n)/最好O(logn)
            //感覺可以用遞迴
            //左右又互換後傳回
            if (root == null)
                return null;

            var tempRoot = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(tempRoot);

            return root;
        }
    }
}
