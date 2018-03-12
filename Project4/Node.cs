/* Project: Project4, Kruskal and Prim Algorithms
 * Organization: SIUE CS 340-001 SP18
 * Project Due: 12/03/2018
 * Programmer: Jacob Grubb
 * File: Node.cs
 */
using System;
using System.Collections.Generic;

namespace Project4
{
    class Node
    {
        public static List<Node> nodeList = new List<Node>();
        private List<Edge> myEdgeList = new List<Edge>();
        private string title;
        private Node parent;
        private int depth = 1;

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
            this.parent = this;
        }

        public void addEdge(Node targetNode, int weight)
        {
            this.myEdgeList.Add(new Edge(this, targetNode, weight));
        }
        public string getTitle()
        {
            return this.title;
        }

        public void setParent(Node newParent)
        {
            this.parent = newParent;
            newParent.incrementDepth(this);
        }

        public Node getParent()
        {
            return this.parent;
        }

        public int getDepth()
        {
            return this.depth;
        }
        public void incrementDepth(Node newChild)
        {
            this.depth = this.depth + newChild.depth;
        }

        public static bool operator ==(Node node1, Node node2)
        {
            return String.Compare(node1.title, node2.title) == 0;
        }

        public static bool operator !=(Node node1, Node node2)
        {
            return !(node1 == node2);
        }

        public static bool operator >(Node node1, Node node2)
        {
            return String.Compare(node1.title, node2.title) == 1;
        }

        public static bool operator <(Node node1, Node node2)
        {
            return String.Compare(node1.title, node2.title) == -1;
        }
        public static bool operator >=(Node node1, Node node2)
        {
            return String.Compare(node1.title, node2.title) > -1;
        }
        public static bool operator <=(Node node1, Node node2)
        {
            return String.Compare(node1.title, node2.title) < 1;
        }
        public override string ToString()
        {
            return (this.getTitle() + " P: " + this.getParent().getTitle());
        }

        public static void resetNodes()
        {
            foreach (Node entry in Node.nodeList)
            {
                entry.setParent(entry);
            }
        }
    }
}
