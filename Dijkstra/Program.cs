using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph();
            g.add_vertex('A', new Dictionary<char, int>() { { 'B', 1 }, { 'C', 2 } });
            g.add_vertex('B', new Dictionary<char, int>() { { 'C', 1 }, { 'D', 5 } , { 'E', 2 } });
            g.add_vertex('C', new Dictionary<char, int>() { { 'D', 2 }, { 'E', 1 }, { 'F', 4 } });
            g.add_vertex('D', new Dictionary<char, int>() { { 'E', 3 },{ 'F', 6 }, { 'G', 8 } });
            g.add_vertex('E', new Dictionary<char, int>() { { 'F', 3 } , { 'G', 7 } });
            g.add_vertex('F', new Dictionary<char, int>() { { 'G', 5 }, { 'H', 2 } });
            g.add_vertex('G', new Dictionary<char, int>() { { 'H', 6 } });
            g.add_vertex('H', new Dictionary<char, int>() { });


            //  g.shortest_path('A', 'F').ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Dijskra ALgorithm");
         foreach(var vertex in g.shortest_path('A', 'F'))
            {
                Console.WriteLine(vertex.Key+","+vertex.Value);
            }

            Console.WriteLine("..................................................");
            Console.WriteLine("FLoyd's Part");
            foreach (var startVertex in g.vertices)
            {
                foreach (var endVertex in g.vertices)
                {
                    Console.WriteLine($"From {startVertex.Key} to {endVertex.Key}");
                    foreach (var vertex in g.shortest_path(startVertex.Key,endVertex.Key))
                    {
                        Console.WriteLine(vertex.Key + "," + vertex.Value);
                    }
                }
                Console.WriteLine("--------------------");
            }
            Console.ReadLine();
        }
    }
}
