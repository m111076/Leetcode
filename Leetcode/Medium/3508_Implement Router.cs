using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class _3508_Implement_Router
    {
        //runtime 75%
        public class Router
        {
            private Queue<(int source, int destination, int timestamp)> queue = new Queue<(int, int, int)>();
            private HashSet<(int source, int destination, int timestamp)> set = new HashSet<(int source, int destination, int timestamp)>();
            private Dictionary<int, List<(int timestamp, int source)>> dic = new Dictionary<int, List<(int timestamp, int source)>>();
            private int _memoryLimit;

            public Router(int memoryLimit)
            {
                _memoryLimit = memoryLimit;
            }

            public bool AddPacket(int source, int destination, int timestamp)
            {
                if (set.Contains((source, destination, timestamp)))
                    return false;

                if (set.Count >= _memoryLimit)
                {
                    ForwardPacket();
                }

                set.Add((source, destination, timestamp));
                queue.Enqueue((source, destination, timestamp));
                if (dic.ContainsKey(destination))
                    dic[destination].Add((timestamp, source));
                else
                    dic.Add(destination, new List<(int timestamp, int source)>() { (timestamp, source) });

                return true;
            }

            public int[] ForwardPacket()
            {
                if (queue.Count == 0)
                    return new int[] { };

                var outSet = queue.Dequeue();
                set.Remove((outSet.source, outSet.destination, outSet.timestamp));
                dic[outSet.destination].Remove((outSet.timestamp, outSet.source));
                if (dic[outSet.destination].Count == 0)
                    dic.Remove(outSet.destination);

                return new int[] { outSet.source, outSet.destination, outSet.timestamp };
            }

            public int GetCount(int destination, int startTime, int endTime)
            {
                if (!dic.ContainsKey(destination))
                    return 0;

                var targets = dic[destination];
                var start = BS(targets, startTime);
                var end = BS(targets, endTime + 1);
                return end - start;
            }

            private int BS(List<(int timestamp, int source)> sets, int time)
            {
                var left = 0;
                var right = sets.Count;

                while (left < right)
                {
                    var mid = left + (right - left) / 2;

                    if (sets[mid].timestamp >= time)
                        right = mid;
                    else
                        left = mid + 1;
                }

                return left;
            }
        }

        //runtime 50%
        //Binary search可以減少搜尋時間
        //public class Router
        //{
        //    public new Queue<Packet> Packets { get; set; } = new Queue<Packet>();
        //    public HashSet<string> PacketSet { get; set; } = new HashSet<string>();
        //    private Dictionary<int, List<int>> DestinationTimestamps { get; set; } = new Dictionary<int, List<int>>();
        //    public int limit { get; set; } = 0;
        //    public Router(int memoryLimit)
        //    {
        //        limit = memoryLimit;
        //    }

        //    public bool AddPacket(int source, int destination, int timestamp)
        //    {
        //        var str = $"{source}-{destination}-{timestamp}";

        //        if (PacketSet.Contains(str))
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            if (Packets.Count >= limit)
        //            {
        //                var remove = Packets.Dequeue();
        //                PacketSet.Remove($"{remove.Source}-{remove.Destination}-{remove.Timestamp}");
        //                DestinationTimestamps[remove.Destination].Remove(remove.Timestamp);
        //            }
        //            Packets.Enqueue(new Packet(source, destination, timestamp));
        //            PacketSet.Add(str);

        //            if (!DestinationTimestamps.ContainsKey(destination))
        //            {
        //                DestinationTimestamps[destination] = new List<int>();
        //            }

        //            DestinationTimestamps[destination].Add(timestamp);
        //        }

        //        return true;
        //    }

        //    public int[] ForwardPacket()
        //    {
        //        if (Packets.Count == 0)
        //        {
        //            return new int[] { };
        //        }

        //        var target = Packets.Dequeue();
        //        PacketSet.Remove($"{target.Source}-{target.Destination}-{target.Timestamp}");
        //        DestinationTimestamps[target.Destination].Remove(target.Timestamp);
        //        return new int[] { target.Source, target.Destination, target.Timestamp };
        //    }


        //    public int GetCount(int destination, int startTime, int endTime)
        //    {
        //        if (DestinationTimestamps.ContainsKey(destination))
        //        {
        //            var target = DestinationTimestamps[destination];
        //            int startIdx = LowerBound(target, startTime);
        //            int endIdx = UpperBound(target, endTime);
        //            return endIdx - startIdx;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }

        //    public int LowerBound(List<int> list, int target)
        //    {
        //        int left = 0, right = list.Count;
        //        while (left < right)
        //        {
        //            int mid = (left + right) / 2;
        //            if (list[mid] < target)
        //                left = mid + 1;
        //            else
        //                right = mid;
        //        }
        //        return left;
        //    }

        //    public int UpperBound(List<int> list, int target)
        //    {
        //        int left = 0, right = list.Count;
        //        while (left < right)
        //        {
        //            int mid = (left + right) / 2;
        //            if (list[mid] <= target)
        //                left = mid + 1;
        //            else
        //                right = mid;
        //        }
        //        return left;
        //    }
        //}

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
