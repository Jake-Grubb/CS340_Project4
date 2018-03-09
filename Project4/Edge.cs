/* Project: Project4, Kruskal and Prim Algorithms
 * Organization: SIUE CS 340-001 SP18
 * Project Due: 12/03/2018
 * Programmer: Jacob Grubb
 * File: Edge.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4
{
    class Edge
    {
        public static List<Edge> edgeList = new List<Edge>();
        private int weight;
        private Node startNode;
        private Node endNode;
        
        public static void swapNodesInList(int entry1, int entry2)
        {
            Edge temp = edgeList[entry1];
            edgeList[entry1] = edgeList[entry2];
            edgeList[entry2] = temp;
        }
        public Edge(Node newStart, Node newEnd, int newWeight)
        {
            this.startNode = newStart;
            this.endNode = newEnd;
            this.weight = newWeight;
            edgeList.Add(this);
        }

        public int getWeight()
        {
            return this.weight;
        }

        public Node getStartNode()
        {
            return this.startNode;
        }
        public Node getEndNode()
        {
            return this.endNode;
        }

        public static bool operator <(Edge edge1, Edge edge2)
        {
            return edge1.weight < edge2.weight;
        }

        public static bool operator >(Edge edge1, Edge edge2)
        {
            return edge1.weight > edge2.weight;
        }

        public static bool operator ==(Edge edge1, Edge edge2)
        {
            return edge1.weight == edge2.weight;
        }

        public static bool operator !=(Edge edge1, Edge edge2)
        {
            return edge1.weight != edge2.weight;
        }

        public static bool operator >=(Edge edge1, Edge edge2)
        {
            return edge1.weight >= edge2.weight;
        }

        public static bool operator <=(Edge edge1, Edge edge2)
        {
            return edge1.weight <= edge2.weight;
        }

        public bool Equals(Edge edge1)
        {
            return (this.weight == edge1.weight) && (this.startNode == edge1.endNode) && (this.endNode == edge1.endNode);
        }

        public override int GetHashCode()
        {
            var hashCode = 560889254;
            hashCode = hashCode * -1521134295 + weight.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Node>.Default.GetHashCode(startNode);
            hashCode = hashCode * -1521134295 + EqualityComparer<Node>.Default.GetHashCode(endNode);
            return hashCode;
        }
    }
}
