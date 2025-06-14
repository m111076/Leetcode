using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0208_Implement_Trie
    {
        //runtime 75%
        //Insert、Search、StartsWith的時間複雜度都是O(n)，其中n為單詞的長度
        public class TrieNode
        {
            public TrieNode[] trieNodes = new TrieNode[26];
            public bool IsEnd { get; set; }
        }

        public class Trie
        {
            private TrieNode root = new TrieNode();

            public Trie()
            {
                root = new TrieNode();
            }

            public void Insert(string word)
            {
                var node = root;

                foreach (var c in word)
                {
                    var target = c - 'a';
                    if (node.trieNodes[target] == null)
                        node.trieNodes[target] = new TrieNode();

                    node = node.trieNodes[target];
                }

                node.IsEnd = true;
            }

            public bool Search(string word)
            {
                return Find(word) == 1;
            }

            public bool StartsWith(string prefix)
            {
                return Find(prefix) != 0;
            }

            private int Find(string word)
            {
                var node = root;

                foreach (var c in word)
                {
                    var target = c - 'a';
                    if (node.trieNodes[target] == null)
                        return 0;

                    node = node.trieNodes[target];
                }

                return node.IsEnd ? 1 : 2;
            }
        }
    }
}
