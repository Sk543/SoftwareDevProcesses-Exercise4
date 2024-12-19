using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    //Graph node implementation for Assessed Exercise 2

    //Hints : 
    //Use lecture materials from Week 9A
    // and lab sheet 'Lab 9: Graphs Implementation' to aid with base implementation...

    //Then see materials for week 10 when moving onto 4B

    // - Adam.M 

    class GraphNode<T>
    {
        public T ID { get; set; }
        private LinkedList<(GraphNode<T>, int)> adjList;

        // Constructor
        public GraphNode(T id)
        {
            ID = id;
            adjList = new LinkedList<(GraphNode<T>, int)>();
        }

        // Add edge without weight
        public void AddEdge(GraphNode<T> to)
        {
            adjList.AddLast((to, 0));
        }

        // Add edge with weight
        public void AddEdgeWithWeight(GraphNode<T> to, int weight)
        {
            adjList.AddLast((to, weight));
        }

        // Get adjacency list
        public LinkedList<T> GetAdjList()
        {
            LinkedList<T> result = new LinkedList<T>();
            foreach (var (node, _) in adjList)
            {
                result.AddLast(node.ID);
            }
            return result;
        }

        // Get edges with weights
        public LinkedList<(T, int)> GetEdgesWithWeights()
        {
            LinkedList<(T, int)> result = new LinkedList<(T, int)>();
            foreach (var (node, weight) in adjList)
            {
                result.AddLast((node.ID, weight));
            }
            return result;
        }
    } // End of class
}
