using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0105_Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
    {
        //runtime 96%
        //time complexity O(n)
        //space complexity O(n)
        private Dictionary<int, int> InorderIndexMap = new Dictionary<int, int>();
        private int PreorderIndex = 0;

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            for (int i = 0; i < inorder.Length; i++)
            {
                InorderIndexMap[inorder[i]] = i;
            }

            return Build(preorder, 0, inorder.Length - 1);
        }

        private TreeNode Build(int[] preorder, int startIdx, int endIdx)
        {
            if (startIdx > endIdx)
                return null;

            var target = preorder[PreorderIndex++];
            var idx = InorderIndexMap[target];
            var node = new TreeNode(target);

            node.left = Build(preorder, startIdx, idx - 1);
            node.right = Build(preorder, idx + 1, endIdx);

            return node;
        }
    }
}
