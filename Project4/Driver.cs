using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Project4
{
    class Driver
    {
        static string inputFileName = "graphin_Fig1.txt";
        static void Main(string[] args)
        {
            string[] inputArray = ReadFile(inputFileName);
            loadTree(inputArray);
            Console.ReadLine();
        }

        static string[] ReadFile(string fileName)
        {
            string[] inputArr = {};
            try
            {
                inputArr = File.ReadAllLines("./" + fileName);
            } catch (IOException e)
            {
                Console.WriteLine("Error, input file \"" + fileName + "\" not found.");
                Environment.Exit(1);
            }
            Console.WriteLine("Input file \"" + fileName + "\" successfully loaded.");
            return inputArr;
        }

        static void loadTree(string[] inArr)
        {
            string[][] splitByWord = new string[inArr.Length][];
            for(int i = 0; i < inArr.Length; i++)
            {
                splitByWord[i] = inArr[i].Split(" ");
            }
            foreach (string[] entry in splitByWord)
            {
                Node temp = new Node(entry[0].Substring(0, 1));
            }
            foreach (string[] entry in splitByWord)
            {
                Node curr = Node.getNodeByName(entry[0].Substring(0, 1));
                for (int i = 0; i < (entry.Length - 1) / 2; i++)
                {
                    curr.addEdge(Node.getNodeByName(entry[i + 1]), Convert.ToInt32(entry[i + 2]));
                }
            }
        }

        static void runKruskal()
        {
            runKruskal();
        }

        static void runPrim()
        {
            runPrim();
        }
    }
}
