using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _1352_Product_of_the_Last_K_Numbers
    {
        public class ProductOfNumbers
        {
            private List<int> _stream = new List<int>();

            public ProductOfNumbers()
            {

            }

            public void Add(int num)
            {
                int n = _stream.Count;
                if (num == 0)
                {
                    _stream.Clear();
                    return;
                }
                if (n == 0)
                {
                    _stream.Add(num);
                }
                else
                {
                    _stream.Add(num * _stream[n - 1]);
                }
            }

            public int GetProduct(int k)
            {
                if (_stream.Count < k)
                {
                    return 0;
                }
                if (_stream.Count == k)
                {
                    return _stream[k - 1];
                }
                return _stream[_stream.Count - 1] / _stream[_stream.Count - k - 1];
            }
        }

    }
}
