using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _1146_Snapshot_Array
    {
        //runtime 82%
        //time complexity : get O(logn)
        //邊界條件要注意
        public class SnapshotArray
        {
            private int _length;
            private int _index;
            private Dictionary<int, List<int[]>> _dictionary = new Dictionary<int, List<int[]>>();

            public SnapshotArray(int length)
            {
                _length = length;
            }

            public void Set(int index, int val)
            {
                if (index >= _length)
                    return;

                if (_dictionary.ContainsKey(index))
                {
                    _dictionary[index].Add(new int[] { _index, val });
                }
                else
                    _dictionary.Add(index, new List<int[]>() { new int[] { _index, val } });
            }

            public int Snap()
            {
                return _index++;
            }

            public int Get(int index, int snap_id)
            {
                if (!_dictionary.ContainsKey(index))
                    return 0;

                var targetIdx = BS(index, snap_id);

                if(targetIdx < 1)
                    return 0;

                return _dictionary[index][targetIdx-1][1];
            }

            private int BS(int index, int snap_id)
            {
                var left = 0;
                var tmpRange = _dictionary[index];
                var right = tmpRange.Count;

                while (left < right)
                {
                    var mid = left + (right - left) / 2;

                    if (tmpRange[mid][0] > snap_id)
                        right = mid;
                    else
                        left = mid + 1;
                }

                return left;
            }
        }
    }
}
