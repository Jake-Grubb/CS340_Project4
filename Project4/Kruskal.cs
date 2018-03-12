using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Project4
{
    static class Kruskal
    {
        
        static public void runKruskal()
        {
            List<Edge> liveTree = new List<Edge>();
            Heap.sort(Edge.edgeList);
            int edgeCounter = -1;
            while(!AreWeDone())
            {
                Edge currEdge = null;
                edgeCounter++;
                if(edgeCounter == Edge.edgeList.Count)
                {
                    break;
                }
                currEdge = Edge.edgeList[edgeCounter];
                //Does it have the same parent?
                if(currEdge.getStartNode().getParent() == currEdge.getEndNode().getParent())
                {                   
                    continue;
                }
                //Check depths
                if (currEdge.getStartNode().getDepth() > currEdge.getEndNode().getDepth())
                {
                    currEdge.getEndNode().setParent(currEdge.getStartNode().getParent());
                    currEdge.getEndNode().incrementDepth(currEdge.getStartNode());
                    liveTree.Add(currEdge);
                    fixChildren(currEdge.getStartNode());
                    fixChildren(currEdge.getEndNode());
                    continue;
                }
                if (currEdge.getStartNode().getDepth() < currEdge.getEndNode().getDepth())
                {
                    currEdge.getStartNode().setParent(currEdge.getEndNode().getParent());
                    currEdge.getStartNode().incrementDepth(currEdge.getEndNode());
                    liveTree.Add(currEdge);
                    fixChildren(currEdge.getStartNode());
                    fixChildren(currEdge.getEndNode());
                    continue;
                }
                //Check by name
                if (currEdge.getStartNode().getParent() > currEdge.getEndNode().getParent())
                {
                    currEdge.getStartNode().setParent(currEdge.getEndNode().getParent());
                    currEdge.getEndNode().incrementDepth(currEdge.getStartNode());
                    fixChildren(currEdge.getStartNode());
                    fixChildren(currEdge.getEndNode());
                    liveTree.Add(currEdge);
                    continue;
                }
                if (currEdge.getStartNode().getParent() < currEdge.getEndNode().getParent())
                {
                    currEdge.getEndNode().setParent(currEdge.getStartNode().getParent());
                    currEdge.getStartNode().incrementDepth(currEdge.getEndNode());
                    fixChildren(currEdge.getStartNode());
                    fixChildren(currEdge.getEndNode());
                    liveTree.Add(currEdge);
                    continue;
                }
                
            }
            outputTree(liveTree);
        }
        static private bool AreWeDone()
        {
            Node testCase = Node.nodeList[0].getParent();
            foreach (Node entry in Node.nodeList)
            {
                if(entry.getParent() != testCase)
                {
                    return false;
                }
            }
            return true;
        }
        static private void fixChildren(Node currNode)
        {
            foreach (Node entry in Node.nodeList)
            {
                if(entry.getParent() == currNode)
                {
                    entry.setParent(currNode.getParent());
                }
            }

        }
        static private void outputTree(List<Edge> activeTree)
        {
            string[] outArray = new string[activeTree.Count];
            for(int i = 0; i < activeTree.Count; i++)
            {
                outArray[i] = activeTree[i].ToString();
            }
            File.WriteAllLines("./kruskalout.txt", outArray);
        }
    }
}
