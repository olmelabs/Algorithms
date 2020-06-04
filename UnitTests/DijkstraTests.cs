using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olmelabs.Algorithms.Others;

namespace Olmelabs.Algorithms.UnitTests
{
    [TestClass]
    public class DijkstraTests
    {
        [TestMethod]
        public void Test_Vertex_0()
        {
            var g = GetGraph();

            var d = new Dijkstra(g, 0);
            d.BuildRoutes();

            var path1 = d.GetShortestPath(0, 1);
            var path2 = d.GetShortestPath(0, 2);
            var path3 = d.GetShortestPath(0, 3);
            var path4 = d.GetShortestPath(0, 4);
            Trace.WriteLine(string.Join(" - ", path1.ToArray()));
            Trace.WriteLine(string.Join(" - ", path2.ToArray()));
            Trace.WriteLine(string.Join(" - ", path3.ToArray()));
            Trace.WriteLine(string.Join(" - ", path4.ToArray()));

        }

        [TestMethod]
        public void Test_Vertex_2()
        {
            var g = GetGraph();

            var d = new Dijkstra(g, 2);
            d.BuildRoutes();

            var path1 = d.GetShortestPath(2, 0);
            var path2 = d.GetShortestPath(2, 1);
            var path3 = d.GetShortestPath(2, 3);
            var path4 = d.GetShortestPath(2, 4);
            Trace.WriteLine(string.Join(" - ", path1.ToArray()));
            Trace.WriteLine(string.Join(" - ", path2.ToArray()));
            Trace.WriteLine(string.Join(" - ", path3.ToArray()));
            Trace.WriteLine(string.Join(" - ", path4.ToArray()));

        }

        [TestMethod]
        public void Test_Vertex_4()
        {
            var g = GetGraph();

            var d = new Dijkstra(g, 4);
            d.BuildRoutes();

            var path1 = d.GetShortestPath(4, 0);
            var path2 = d.GetShortestPath(4, 1);
            var path3 = d.GetShortestPath(4, 2);
            var path4 = d.GetShortestPath(4, 3);
            Trace.WriteLine(string.Join(" - ", path1.ToArray()));
            Trace.WriteLine(string.Join(" - ", path2.ToArray()));
            Trace.WriteLine(string.Join(" - ", path3.ToArray()));
            Trace.WriteLine(string.Join(" - ", path4.ToArray()));

        }


        private List<List<Dijkstra.GraphNode>> GetGraph()
        {
            //this graph https://miro.medium.com/max/1400/1*DcCsQRtkOCusXQFodZ7IhA.jpeg
            return new List<List<Dijkstra.GraphNode>>
            {
                //node 0 - a
                new List<Dijkstra.GraphNode>(new[]
                {
                    new Dijkstra.GraphNode(){Vertex = 1, Weight = 7},
                    new Dijkstra.GraphNode(){Vertex = 2, Weight = 3}
                }),

                //node 1 - b
                new List<Dijkstra.GraphNode>(new[]
                {
                    new Dijkstra.GraphNode(){Vertex = 0, Weight = 7},
                    new Dijkstra.GraphNode(){Vertex = 2, Weight = 1},
                    new Dijkstra.GraphNode(){Vertex = 3, Weight = 2},
                    new Dijkstra.GraphNode(){Vertex = 4, Weight = 6}
                }),

                //node 2 - c
                new List<Dijkstra.GraphNode>(new[]
                {
                    new Dijkstra.GraphNode(){Vertex = 0, Weight = 3},
                    new Dijkstra.GraphNode(){Vertex = 1, Weight = 1},
                    new Dijkstra.GraphNode(){Vertex = 3, Weight = 2}
                }),

                //node 3 - d
                new List<Dijkstra.GraphNode>(new[]
                {
                    new Dijkstra.GraphNode(){Vertex = 1, Weight = 2},
                    new Dijkstra.GraphNode(){Vertex = 2, Weight = 2},
                    new Dijkstra.GraphNode(){Vertex = 4, Weight = 4},
                }),

                //node 4 - e
                new List<Dijkstra.GraphNode>(new[]
                {
                    new Dijkstra.GraphNode(){Vertex = 1, Weight = 6},
                    new Dijkstra.GraphNode(){Vertex = 3, Weight = 4},
                })
            };
        }
    }
}
