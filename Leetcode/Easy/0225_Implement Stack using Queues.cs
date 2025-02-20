using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _0225_Implement_Stack_using_Queues
    {
        //runtime 87% memory 33%
        Queue<int> queue1;
        Queue<int> queue2;

        public _0225_Implement_Stack_using_Queues()
        {
            queue1 = new Queue<int>();
            queue2 = new Queue<int>();
        }

        public void Push(int x)
        {
            queue1.Enqueue(x);
        }

        public int Pop()
        {
            if (queue1.Count == 0)
                return 0;

            var amount = 0;
            var target = 0;

            target = queue1.Dequeue();

            while (amount < queue1.Count)
            {
                queue1.Enqueue(target);
                amount++;
                target = queue1.Dequeue();
            }
            return target;
        }

        public int Top()
        {
            var amount = 0;
            var target = 0;
            while (amount < queue1.Count)
            {
                amount++;
                target = queue1.Dequeue();
                queue1.Enqueue(target);
            }
            return target;
        }

        public bool Empty()
        {
            return queue1.Count == 0;
        }
    }
}
