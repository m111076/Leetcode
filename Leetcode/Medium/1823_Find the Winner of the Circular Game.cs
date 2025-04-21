using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1823_Find_the_Winner_of_the_Circular_Game
    {
        public int FindTheWinner(int n, int k)
        {
            //此為Josephus Problem
            //可套用其遞推的公式
            //f(n,k) = (f(n-1,k) + k) % n,f(1,k)=0
            //runtime 100%
            //time complexity O(n)
            //space complexity O(1)
            var result = 0;

            for (var i = 2; i <= n; i++)
            {
                result = (result + k) % i;
            }

            return result + 1;

            //runtime 7%
            //time complexity O(n^2)
            //space complexity O(n)
            if (k == 1)
                return n;

            var tmp = new Queue<int>();
            var cnt = 0;

            for (var i = 1; i <= n; i++)
            {
                cnt++;
                if (cnt == k)
                {
                    cnt = 0;
                }
                else
                {
                    tmp.Enqueue(i);
                }
            }

            while (tmp.Count > 1)
            {
                cnt++;
                if (cnt == k)
                {
                    cnt = 0;
                    tmp.Dequeue();
                }
                else
                {
                    tmp.Enqueue(tmp.Dequeue());
                }
            }

            return tmp.Dequeue();
        }
    }
}
