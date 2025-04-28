using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _3408_Design_Task_Manager
    {
        //runtime 93%
        //Comparer用法
        //CompareTo的比較順序
        //(a,b)=>a.CompareTo(b)升序、b.CompareTo(a)降序
        public class TaskManager
        {
            private PriorityQueue<int, (int taskId, int priority)> TaskQueue;
            private Dictionary<int, (int userId, int priority)> UserTasks;

            public TaskManager(IList<IList<int>> tasks)
            {
                UserTasks = new Dictionary<int, (int userId, int priority)>();
                TaskQueue = new PriorityQueue<int, (int taskId, int priority)>(Comparer<(int taskId, int priority)>.Create((a, b) =>
                {
                    if (a.priority != b.priority)
                        return b.priority.CompareTo(a.priority);

                    return b.taskId.CompareTo(a.taskId);
                }));

                foreach (var task in tasks)
                {
                    Add(task[0], task[1], task[2]);
                }
            }

            public void Add(int userId, int taskId, int priority)
            {
                TaskQueue.Enqueue(userId, (taskId, priority));
                UserTasks[taskId] = (userId, priority);
            }

            public void Edit(int taskId, int newPriority)
            {
                if (UserTasks.TryGetValue(taskId, out var current))
                {
                    UserTasks[taskId] = (current.userId, newPriority);
                    TaskQueue.Enqueue(current.userId, (taskId, newPriority));
                }
            }

            public void Rmv(int taskId)
            {
                UserTasks.Remove(taskId);
            }

            public int ExecTop()
            {
                while (TaskQueue.Count > 0)
                {
                    if (!TaskQueue.TryDequeue(out var targetID, out var target))
                        continue;

                    if (UserTasks.TryGetValue(target.taskId, out var tmpTarget) && tmpTarget.userId == targetID && tmpTarget.priority == target.priority)
                    {
                        UserTasks.Remove(target.taskId);
                        return targetID;
                    }
                }

                return -1;
            }
        }
    }
}
