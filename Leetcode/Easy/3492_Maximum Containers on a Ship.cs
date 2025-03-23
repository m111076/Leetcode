using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class _3492_Maximum_Containers_on_a_Ship
    {
        public int MaxContainers(int n, int w, int maxWeight)
        {
            var toatl = n * n;

            return toatl * w <= maxWeight ? toatl : maxWeight / w;
        }
    }
}
