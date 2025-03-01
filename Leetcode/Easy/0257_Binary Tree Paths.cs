using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0257_Binary_Tree_Paths
    {
        public IList<string> result = new List<string>();

        //runtine 43%
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            if (root == null)
                return result;

            var tmpStr = string.Empty;
            dfs(root, tmpStr);

            return result;
        }

        public void dfs(TreeNode iRoot, string iPath)
        {
            iPath += $"{iRoot.val}";

            if (iRoot.left == null && iRoot.right == null)
            {
                result.Add(iPath);
                return;
            }

            iPath += $"->";

            if (iRoot.left != null)
                dfs(iRoot.left, iPath);
            if (iRoot.right != null)
                dfs(iRoot.right, iPath);
        }


    }
}
