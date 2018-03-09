using System;
using System.Collections.Generic;
using System.Text;

namespace Project4
{
    class Edge
    {
        int weight;
        Node startNode;
        Node endNode;
        
        public Edge(Node newStart, Node newEnd, int newWeight)
        {
            this.startNode = newStart;
            this.endNode = newEnd;
            this.weight = newWeight;
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
