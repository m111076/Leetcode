using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0232_Implement_Queue_using_Stacks
    {
        public Stack<int> stack1;
        public Stack<int> stack2;
        public _0232_Implement_Queue_using_Stacks()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        public void Push(int x)
        {
            stack1.Push(x);
        }

        public int Pop()
        {
            if (stack1.Count == 0) return default;

            int? target = null;
            while (stack1.Count > 0)
            {
                if (target != null)
                    stack2.Push(target.Value);
                target = stack1.Pop();
            }
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }

            return target.Value;
        }

        public int Peek()
        {
            int target = 0;

            while (stack1.Count > 0)
            {
                target = stack1.Pop();
                stack2.Push(target);
            }
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }

            return target;
        }

        public bool Empty()
        {
            return stack1.Count == 0;
        }
    }
}
