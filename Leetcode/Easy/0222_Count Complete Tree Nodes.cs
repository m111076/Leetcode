using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0222_Count_Complete_Tree_Nodes
    {
        public int CountNodes(TreeNode root)
        {
            //runtime 100% memory 20%
            if (root == null) return 0;

            return 1 + CountNodes(root.left) + CountNodes(root.right);

        }
    }
}
