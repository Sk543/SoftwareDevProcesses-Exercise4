using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    //Graph implementation for Assessed Exercise 4

    //Hints : 
    //Use lecture materials from Week 9A
    // and lab sheet 'Lab 9: Graphs Implementation' to aid with base implementation...

    //For 4B, review material from lecture 9B and lab 10 to aid with the implementation of these metrics

    //For 4C, see lecture 10A and lab 10 to aid with your traversal implementation

    //To address the last task for 4C, you can use BFS or DFS to as an idea of how to start off, but remember that we're only
    // interested in loot that can be obtained from the safest possible route, so we don't nessicarily need to find everything on the network as in
    // BFS and DFS!

    // - Adam.M 

    class Graph<T> where T : IComparable
    {
        private Dictionary<T, GraphNode<T>> nodes;
        private int edgeCount;

        // Constructor
        public Graph()
        {
            nodes = new Dictionary<T, GraphNode<T>>();
            edgeCount = 0;
        }

        // Add node
        public void AddNode(T id)
        {
            if (!nodes.ContainsKey(id))
            {
                nodes[id] = new GraphNode<T>(id);
            }
        }

        // Add edge without weight
        public void AddEdge(T from, T to)
        {
            if (nodes.ContainsKey(from) && nodes.ContainsKey(to))
            {
                nodes[from].AddEdge(nodes[to]);
                edgeCount++;
            }
        }

        // Add edge with weight
        public void AddWeightedEdge(T from, T to, int weight)
        {
            if (nodes.ContainsKey(from) && nodes.ContainsKey(to))
            {
                nodes[from].AddEdgeWithWeight(nodes[to], weight);
                edgeCount++;
            }
        }

        // Get number of nodes
        public int NumNodes()
        {
            return nodes.Count;
        }

        // Get number of edges
        public int NumEdges()
        {
            return edgeCount;
        }

        // Calculate average outbound edges
        public double AverageOutbound()
        {
            return edgeCount / (double)nodes.Count;
        }

        // Calculate average weight
        public double AverageWeight()
        {
            double totalWeight = 0;
            foreach (var node in nodes.Values)
            {
                foreach (var (_, weight) in node.GetEdgesWithWeights())
                {
                    totalWeight += weight;
                }
            }
            return totalWeight / edgeCount;
        }

        // Get all adjacencies for a node
        public List<T> GetAllAdjacencies(T id)
        {
            if (nodes.ContainsKey(id))
            {
                return new List<T>(nodes[id].GetAdjList());
            }
            return new List<T>();
        }

    }
