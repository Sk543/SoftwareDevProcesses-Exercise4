using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new graph instance
            Graph<string> graph = new Graph<string>();

            while (true)
            {
                // Display menu options
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add Loot Node");
                Console.WriteLine("2. Add Edge");
                Console.WriteLine("3. Add Weighted Edge");
                Console.WriteLine("4. Display Graph Metrics");
                Console.WriteLine("5. Perform BFS");
                Console.WriteLine("6. Find Safest Route");
                Console.WriteLine("7. Exit");

                // Read user choice
                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Add a new node to the graph
                        Console.WriteLine("Enter node ID:");
                        string nodeId = Console.ReadLine();
                        graph.AddNode(nodeId);
                        break;

                    case 2:
                        // Add an edge between two nodes
                        Console.WriteLine("Enter from node ID:");
                        string from = Console.ReadLine();
                        Console.WriteLine("Enter to node ID:");
                        string to = Console.ReadLine();
                        graph.AddEdge(from, to);
                        break;

                    case 3:
                        // Add a weighted edge between two nodes
                        Console.WriteLine("Enter from node ID:");
                        from = Console.ReadLine();
                        Console.WriteLine("Enter to node ID:");
                        to = Console.ReadLine();
                        Console.WriteLine("Enter weight:");
                        int weight = Int32.Parse(Console.ReadLine());
                        graph.AddWeightedEdge(from, to, weight);
                        break;

                    case 4:
                        // Display graph metrics
                        Console.WriteLine($"Number of Nodes: {graph.NumNodes()}");
                        Console.WriteLine($"Number of Edges: {graph.NumEdges()}");
                        Console.WriteLine($"Average Outbound: {graph.AverageOutbound()}");
                        Console.WriteLine($"Average Weight: {graph.AverageWeight()}");
                        break;

                    case 5:
                        // Perform BFS traversal starting from a specified node
                        Console.WriteLine("Enter start node ID:");
                        string start = Console.ReadLine();
                        List<string> visitedBFS = new List<string>();
                        graph.BFS(start, ref visitedBFS);
                        Console.WriteLine("BFS Traversal: " + string.Join(", ", visitedBFS));
                        break;

                    case 6:
                        // Find the safest route starting from a specified node
                        Console.WriteLine("Enter start node ID:");
                        start = Console.ReadLine();
                        List<string> visitedSafest = new List<string>();
                        graph.SafestRoute(start, ref visitedSafest);
                        Console.WriteLine("Safest Route: " + string.Join(", ", visitedSafest));
                        break;

                    case 7:
                        // Exit the program
                        return;

                    default:
                        // Handle invalid options
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
