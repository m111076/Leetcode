using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _3508_Implement_Router
    {
        //runtime 50%
        //Binary search可以減少搜尋時間
        public class Router
        {
            public new Queue<Packet> Packets { get; set; } = new Queue<Packet>();
            public HashSet<string> PacketSet { get; set; } = new HashSet<string>();
            private Dictionary<int, List<int>> DestinationTimestamps { get; set; } = new Dictionary<int, List<int>>();
            public int limit { get; set; } = 0;
            public Router(int memoryLimit)
            {
                limit = memoryLimit;
            }

            public bool AddPacket(int source, int destination, int timestamp)
            {
                var str = $"{source}-{destination}-{timestamp}";

                if (PacketSet.Contains(str))
                {
                    return false;
                }
                else
                {
                    if (Packets.Count >= limit)
                    {
                        var remove = Packets.Dequeue();
                        PacketSet.Remove($"{remove.Source}-{remove.Destination}-{remove.Timestamp}");
                        DestinationTimestamps[remove.Destination].Remove(remove.Timestamp);
                    }
                    Packets.Enqueue(new Packet(source, destination, timestamp));
                    PacketSet.Add(str);

                    if (!DestinationTimestamps.ContainsKey(destination))
                    {
                        DestinationTimestamps[destination] = new List<int>();
                    }

                    DestinationTimestamps[destination].Add(timestamp);
                }

                return true;
            }

            public int[] ForwardPacket()
            {
                if (Packets.Count == 0)
                {
                    return new int[] { };
                }

                var target = Packets.Dequeue();
                PacketSet.Remove($"{target.Source}-{target.Destination}-{target.Timestamp}");
                DestinationTimestamps[target.Destination].Remove(target.Timestamp);
                return new int[] { target.Source, target.Destination, target.Timestamp };
            }


            public int GetCount(int destination, int startTime, int endTime)
            {
                if (DestinationTimestamps.ContainsKey(destination))
                {
                    var target = DestinationTimestamps[destination];
                    int startIdx = LowerBound(target, startTime);
                    int endIdx = UpperBound(target, endTime);
                    return endIdx - startIdx;
                }
                else
                {
                    return 0;
                }
            }

            public int LowerBound(List<int> list, int target)
            {
                int left = 0, right = list.Count;
                while (left < right)
                {
                    int mid = (left + right) / 2;
                    if (list[mid] < target)
                        left = mid + 1;
                    else
                        right = mid;
                }
                return left;
            }

            public int UpperBound(List<int> list, int target)
            {
                int left = 0, right = list.Count;
                while (left < right)
                {
                    int mid = (left + right) / 2;
                    if (list[mid] <= target)
                        left = mid + 1;
                    else
                        right = mid;
                }
                return left;
            }
        }

        public class Packet
        {
            public int Source { get; set; }
            public int Destination { get; set; }
            public int Timestamp { get; set; } = new int();
            public Packet(int source, int destination, int timestamp)
            {
                Source = source;
                Destination = destination;
                Timestamp = timestamp;
            }
        }
    }
}
