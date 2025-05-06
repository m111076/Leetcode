using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0911_Online_Election
    {
        //runtime 29%
        //time complexity =>Q O(logn)
        public class TopVotedCandidate
        {
            private Dictionary<int, int> _votes = new Dictionary<int, int>();
            private int[][] timeList;
            public TopVotedCandidate(int[] persons, int[] times)
            {
                timeList = new int[persons.Length][];
                var idx = -1;
                var maxAmount = -1;

                for (int i = 0; i < persons.Length; i++)
                {
                    if (!_votes.TryAdd(persons[i], 1))
                        _votes[persons[i]]++;

                    if (_votes[persons[i]] >= maxAmount)
                    {
                        idx = persons[i];
                        maxAmount = _votes[persons[i]];
                    }

                    timeList[i] = new int[] { times[i], idx };
                }

            }

            public int Q(int t)
            {
                var left = 0;
                var right = timeList.Length;

                while (left < right)
                {
                    var mid = left + (right - left) / 2;

                    if (timeList[mid][0] > t)
                        right = mid;
                    else
                        left = mid + 1;
                }

                return timeList[left - 1][1];
            }
        }
    }
}
