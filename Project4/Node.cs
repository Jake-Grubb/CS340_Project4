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

        public Node(string newTitle)
        {
            this.title = newTitle;
            nodeList.Add(this);
        }

        public void addEdge(Node targetNode, int weight)
        {
            this.myEdgeList.Add(new Edge(this, targetNode, weight));
        }
    }
}
