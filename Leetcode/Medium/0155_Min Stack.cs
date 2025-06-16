using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0155_Min_Stack
    {
        public class MinStack
        {
            //runtime 62%  
            //time complexity O(1) for all operations
            private Stack<int> stack;
            private Stack<int> minStack;

            public MinStack()
            {
                stack = new Stack<int>();
                minStack = new Stack<int>();
            }

            public void Push(int val)
            {
                stack.Push(val);
                if (minStack.Count == 0 || val <= minStack.Peek())
                    minStack.Push(val);
                else
                    minStack.Push(minStack.Peek());
            }

            public void Pop()
            {
                stack.Pop();
                minStack.Pop();
            }

            public int Top()
            {
                return stack.Peek();
            }

            public int GetMin()
            {
                return minStack.Peek();
            }
        }
    }
}
