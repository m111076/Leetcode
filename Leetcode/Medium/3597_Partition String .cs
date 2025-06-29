using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3597_Partition_String
    {
        public IList<string> PartitionString(string s)
        {
            //runtime 97%
            //time complexity O(n)
            //space complexity O(n)
            var result = new List<string>();
            var tmp = new StringBuilder();
            var trie = new CharNode();
            var tmpTrie = trie;

            foreach (char c in s)
            {
                tmp.Append(c);
                var idx = c - 'a';

                if (tmpTrie.ChildNodes[idx] == null)
                {
                    tmpTrie.ChildNodes[idx] = new CharNode();
                    tmpTrie.ChildNodes[idx].IsValid = true;
                    result.Add(tmp.ToString());
                    tmp.Clear();
                    tmpTrie = trie;
                }
                else
                {
                    tmpTrie = tmpTrie.ChildNodes[idx];
                }
            }

            return result;

            //runtime 67%
            //time complexity O(n^2)
            //space complexity O(n^2)
            //var set = new HashSet<string>();
            //var tmp = new StringBuilder();
            //var tmpStr = "";

            //for (int i = 0; i < s.Length; i++)
            //{
            //    tmp.Append(s[i]);
            //    tmpStr = tmp.ToString();//O(n)

            //    if (!set.Contains(tmpStr))
            //    {
            //        set.Add(tmpStr);
            //        tmp.Clear();
            //    }
            //}

            //return set.ToList();
        }

        public class CharNode
        {
            public readonly CharNode[] ChildNodes = new CharNode[26];
            public bool IsValid { get; set; }
        }
    }
}
