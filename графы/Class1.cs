using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace lab4
{
    class Class1
    {
        static public void DFS(int [,] graph, int i, int n, ref bool [] used)
        {
            used[i] = true;
            int j = 0;
            for (j = 0; j < n; j++)
                if ((used[j] == false) && (graph [i, j] != 0))
                        DFS(graph, j, n, ref used);
        }
        static public void BFS(int[,] graph, int it, int n, ref bool[] used)
        {
            Queue<int> q= new Queue<int>();
            used[it] = true;
            q.Enqueue(it);
            while (q.Count() > 0)
            {
                int k = q.Dequeue();
                for (int i = 0; i < n; i++)
                    if ((used[i] == false) && (graph[k, i] != 0))
                    {
                        q.Enqueue(i);
                        used[i] = true;
                    }
            }
        }
        static public void deix(int[,] graph, int it, int n, ref bool[] used, int end)
        {
            int[] minim = { Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue };
            int[] nomer = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            used[it] = true;
            for (int i = 0; i < n; i++)
            {
                if (graph[it, i] != 0)
                    minim[i] = graph[it, i];
            }
            minim[it] = 0; // расстояние до начальной 0
            int m = Int32.MaxValue;
            int index = -1;
            for (int i = 0; i < n; i++)

                if (!used[i] && m > minim[i])
                {
                    m = minim[i];
                    index = i;
                }
            //находим вершину с минимальным расстоянием от начальной
            while (index != -1) // пока находится вершина с минимальным расстоянием 
            {
                used[index] = true;
                // пытаемся обновить расстояния
                for (int k = 0; k < n; k++)
                {
                    if (!used[k] && graph[index, k] != 0 && minim[k] > minim[index] + graph[index, k])
                    {
                        minim[k] = minim[index] + graph[index, k];
                        nomer[k] = index;
                    }
                }
                // снова ищем минимальную
                m = Int32.MaxValue;
                index = -1;
                for (int i = 0; i < n; i++)

                    if (!used[i] && m > minim[i])
                    {
                        m = minim[i];
                        index = i;
                    }
            }
            //выводим путь, если можем дойти иначе выводим -1
            if (minim[end] != Int32.MaxValue)
            {
                Console.WriteLine(minim[end]);
                int z = end;
                List<int> path = new List<int>();
                path.Add(z);
                while (z != it)
                {
                    z = nomer[z];
                    path.Add(z + 1);
                }

                path.Reverse();
                for (int i = 0; i < path.Count; i++)
                    Console.WriteLine(path[i]);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }



        public struct edge
        {
            public int w, st, fin;

            public static int cmp(edge a, edge b)
            {
                return a.w - b.w;
            }

            public edge(int w, int st, int fin)
            {
                this.w = w;
                this.fin = fin;
                this.st = st;
            }
        }
        public static long Kruscal(List<int> graph, List<edge> edges)
        {
            long sum = 0;
            edge tmp;
            int count = 0;
            for (int i = 0; i < edges.Count; i++)
            {
                tmp = edges[i];
                if ((graph[tmp.st] == -1) && (graph[tmp.fin] == -1))
                {
                    count++;
                    graph[tmp.st] = count;
                    graph[tmp.fin] = count;
                    sum = sum + tmp.w;
                }
                if ((graph[tmp.st] == -1) || (graph[tmp.fin] == -1))
                {
                    if (graph[tmp.st] != -1)
                        graph[tmp.fin] = graph[tmp.st];
                    else
                        graph[tmp.st] = graph[tmp.fin];
                    sum = sum + tmp.w;
                }
                if (graph[tmp.st] != graph[tmp.fin])
                {
                    int color_fin = graph[tmp.fin];
                    for (int j = 1; j < graph.Count; j++)
                        if (graph[j] == color_fin)
                            graph[j] = graph[tmp.st];
                    sum = sum + tmp.w;
                }
            }

            return sum;
        }



    }
}
