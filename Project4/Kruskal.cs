using System;
using System.Collections.Generic;
using System.Text;

namespace Project4
{
    static class Kruskal
    {
        static public void runKruskal()
        {

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
    }
}
