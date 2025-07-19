using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1233_Remove_Sub_Folders_from_the_Filesystem
    {
        //runtime 57%
        //time complexity O(nlogn+L*n)
        //space complexity O(1)
        //也可以用trie來做
        public IList<string> RemoveSubfolders(string[] folder)
        {
            Array.Sort(folder);

            var result = new List<string>();
            result.Add(folder[0]);

            for (var i = 1; i < folder.Length; i++)
            {
                var last = result.Last();
                if (!folder[i].StartsWith(last + "/"))
                {
                    result.Add(folder[i]);
                }
            }

            return result;
        }
    }
}
