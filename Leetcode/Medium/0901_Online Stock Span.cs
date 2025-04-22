using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0901_Online_Stock_Span
    {
        public class StockSpanner
        {
            private Stack<int> _stack = new Stack<int>();
            private Queue<int> _queue = new Queue<int>();
            private Stack<(int Price, int Span)> _stack2;

            public StockSpanner()
            {
                _stack2 = new Stack<(int Price, int Span)>();
            }

            public int Next(int price)
            {
                //runtime 99%
                //time complexity O(n)
                //space complexity O(n)
                var Span = 1;

                while (_stack2.Count > 0 && _stack2.Peek().Price <= price)
                {
                    Span += _stack2.Pop().Span;
                }

                _stack2.Push((price, Span));

                return Span;

                //runtime 5%
                //time complexity O(n)
                //space complexity O(n)
                while (_stack.Count > 0 && _stack.Peek() <= price)
                {
                    _queue.Enqueue(_stack.Pop());
                }

                var result = _queue.Count + 1;

                while (_queue.Count > 0)
                {
                    _stack.Push(_queue.Dequeue());
                }

                _stack.Push(price);

                return result;
            }
        }
    }
}
