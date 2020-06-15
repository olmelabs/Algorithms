
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Olmelabs.Algorithms.Others
{
    public class Dijkstra
    {
        private const int Infinity = int.MaxValue;
        public class GraphNode
        {
            public int Vertex { get; set; }
            public int Weight { get; set; }
        }

        public class RouteTableRow
        {
            public RouteTableRow(int currentVertex)
            {
                Vertex = currentVertex;
                Distance = Infinity;
            }
            public int Vertex { get; set; }
            public int Distance { get; set; }
            public int? PrevVertex { get; set; }
        }

        private readonly List<List<GraphNode>> graph;

        private readonly List<int> visited;
        private readonly List<int> unvisited;

        private readonly List<RouteTableRow> routes;

        public Dijkstra(List<List<GraphNode>> graph, int startVortex)
        {
            this.graph = graph;

            routes = new List<RouteTableRow>(graph.Count);

            unvisited = new List<int>(graph.Count);
            for (var i = 0; i < graph.Count; i++)
            {
                unvisited.Add(i);
                routes.Add(new RouteTableRow(i));
            }

            //Start from start node to itself is 0
            routes.First(r => r.Vertex == startVortex).Distance = 0;

            visited = new List<int>(graph.Count);
        }

        public List<RouteTableRow> BuildRoutes()
        {
            var step = 0;
            DumpState(step);

            while (unvisited.Count > 0)
            {
                //get non-visited vertex with smallest distance
                var row = routes.Where(r => !visited.Contains(r.Vertex)).OrderBy(r => r.Distance).First();

                //calculate the distance to neighbors
                foreach (var neighbor in graph[row.Vertex])
                {
                    if (visited.Contains(neighbor.Vertex))
                        continue;

                    //The distance to node the existing cost  plus new route cost:
                    var distance = routes.First(r => r.Vertex == row.Vertex).Distance + neighbor.Weight;

                    //if the calculated distance is less than our currently-known shortest distance for these neighboring nodes,
                    //update our tables values with our new "shortest distance"
                    var neighborRow = routes.First(r => r.Vertex == neighbor.Vertex);
                    if (distance < neighborRow.Distance)
                    {
                        neighborRow.Distance = distance;
                        neighborRow.PrevVertex = row.Vertex;
                    }
                }

                visited.Add(row.Vertex);
                unvisited.Remove(row.Vertex);

                step++;
                DumpState(step);
            }

            return routes;
        }

        private void DumpState(int step)
        {
            Trace.WriteLine($"Step {step}");
            Trace.WriteLine($"Unvisited: {string.Join(", ", unvisited)}");
            Trace.WriteLine($"Visited: {string.Join(",", visited)}");
            Trace.WriteLine(" Vtx | Dist | Prev");
            foreach (var row in routes)
            {
                Trace.WriteLine($" {row.Vertex}   | {(row.Distance == Infinity ? "-" : row.Distance.ToString())}    | {row.PrevVertex}");
            }
        }

        public List<int> GetShortestPath(int fromVertex, int toVertex)
        {
            var s = new Stack<int>();
            var curr = toVertex;

            while (curr != fromVertex)
            {
                s.Push(curr);
                curr = routes.First(r => r.Vertex == curr).PrevVertex ?? throw new Exception();
            }
            s.Push(curr);

            var res = new List<int>(s.Count);
            while (s.Count > 0)
            {
                res.Add(s.Pop());
            }

            return res;
        }
    }
}
