using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{

    
        class Program
    {
        public static void Main(string[] args)
        {
            int[,] graph = { 
                              { 0, 2, 0, 3, 5, 0, 0, 0, 0 },
                              { 2, 0, 10, 0, 0, 0, 0, 0, 0},
                              { 0, 10, 0, 0, 2, 0, 0, 5, 6},
                              { 3, 0, 0, 0, 0, 8, 0, 0, 0},
                              { 5, 0, 2, 0, 0, 7, 0, 0, 0},
                              { 0, 0, 0, 8, 7, 0, 4, 3, 0},
                              { 0, 0, 0, 0, 0, 4, 0, 0, 11},
                              { 0, 0, 5, 0, 0, 3, 0, 0, 0},
                              { 0, 0, 6, 0, 0, 0, 11, 0, 0} };
            bool[] used = { false, false, false, false, false, false, false, false, false};
            //Class1.DFS(graph, 1, 9, ref used);
            //Class1.BFS(graph, 1, 9, ref used);
            //Class1.deix(graph, 0, 9, ref used, );

            List<int> g = new List<int>();
            List<Class1.edge> edges = new List<Class1.edge>();
            for (int i = 0; i < 9; i++)
                g.Add(-1);
            for (int i = 0; i < 9; i++)
                for (int j = i; j < 9; j++)
                    if (graph[i, j] != 0)
                        edges.Add(new Class1.edge(graph[i, j], i, j));

            edges.Sort(Class1.edge.cmp);
            Console.WriteLine(Class1.Kruscal(g, edges));

            // for (int i = 0; i < 9; i++)
            // Console.WriteLine("{0} ",used[i]);

        }
    }
}
