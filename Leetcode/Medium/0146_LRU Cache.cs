using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0146_LRU_Cache
    {
        public class LRUCache
        {
            //runtime 76%
            private class Node
            {
                public Node(int k, int v) { key = k; value = v; }

                public int key, value;
                public Node prev, next;
            }

            private int capacity;
            private Dictionary<int, Node> cache = new Dictionary<int, Node>();
            private Node dummy = new Node(0, 0);

            public LRUCache(int capacity)
            {
                this.capacity = capacity;
                dummy.prev = dummy;
                dummy.next = dummy;
            }

            public int Get(int key)
            {
                var node = GetNode(key);

                return node == null ? -1 : node.value;
            }

            public void Put(int key, int value)
            {
                var node = GetNode(key);

                if (node != null)
                    node.value = value;
                else
                {
                    node = new Node(key, value);
                    cache.Add(key, node);
                    MoveToEnd(node);
                    if (cache.Count > capacity)
                    {
                        var tmpEnd = dummy.prev;
                        Remove(tmpEnd);
                        cache.Remove(tmpEnd.key);
                    }
                }
            }

            private void Remove(Node node)
            {
                node.prev.next = node.next;
                node.next.prev = node.prev;
            }

            private Node GetNode(int key)
            {
                if (!cache.ContainsKey(key))
                    return null;

                var node = cache[key];
                Remove(node);
                MoveToEnd(node);

                return node;
            }

            private void MoveToEnd(Node node)
            {
                node.prev = dummy;
                node.next = dummy.next;
                node.prev.next = node;
                node.next.prev = node;
            }
        }
    }
}
