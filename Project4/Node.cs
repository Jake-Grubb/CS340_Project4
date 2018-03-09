/* Project: Project4, Kruskal and Prim Algorithms
 * Organization: SIUE CS 340-001 SP18
 * Project Due: 12/03/2018
 * Programmer: Jacob Grubb
 * File: Node.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4
{
    class Node
    {
        public static List<Node> nodeList = new List<Node>();
        private List<Edge> myEdgeList = new List<Edge>();
        private string title;

        public static Node getNodeByName(string name)
        {
            foreach (Node entry in nodeList)
            {
                if(String.Compare(entry.getTitle(), name) == 0)
                {
                    return entry;
                }
            }
            return null;
        }
        public Node(string newTitle)
        {
            this.title = newTitle;
            nodeList.Add(this);
        }

        public void addEdge(Node targetNode, int weight)
        {
            this.myEdgeList.Add(new Edge(this, targetNode, weight));
        }
        public string getTitle()
        {
            return this.title;
        }
    }
}
