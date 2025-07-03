using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    internal class _0207_Course_Schedule
    {
        //runtime 99.54
        //time complexity O(n+p)
        //sapce complexity O()
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var graph = new List<int>[numCourses];
            for (var i = 0; i < numCourses; i++)
            {
                graph[i] = new List<int>();
            }

            foreach (var p in prerequisites)
            {
                graph[p[1]].Add(p[0]);
            }

            var state = new int[numCourses];
            for (var i = 0; i < numCourses; i++)
            {
                if (state[i] == 0 && DFS(i, graph, state))
                    return false;
            }

            return true;
        }

        private bool DFS(int course, List<int>[] graph, int[] state)
        {
            state[course] = 1;

            foreach (var p in graph[course])
            {
                if (state[p] == 1 || state[p] == 0 && DFS(p, graph, state))
                    return true;
            }

            state[course] = 2;

            return false;
        }
    }
}
