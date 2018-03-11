/* Project: Project4, Kruskal and Prim Algorithms
 * Organization: SIUE CS 340-001 SP18
 * Project Due: 12/03/2018
 * Programmer: Jacob Grubb
 * File: Driver.cs
 */
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
            string[] inputArr = {}; //Create an empty string array, because of how we read our input.
            try
            {
                inputArr = File.ReadAllLines("./" + fileName); //ReadAllLines will return a string arr of every line in the file
            } catch (IOException e)
            {
                Console.WriteLine("Error, input file \"" + fileName + "\" not found."); //Exceptions, self explanatory.
                Environment.Exit(1);
            }
            Console.WriteLine("Input file \"" + fileName + "\" successfully loaded.");
            return inputArr;
        }

        static void loadTree(string[] inArr)
        {
            string[][] splitByWord = new string[inArr.Length][]; //Create a 2D array of arr[lineofText][wordsInLine]
            for(int i = 0; i < inArr.Length; i++)
            {
                splitByWord[i] = inArr[i].Split(" "); //We will split each apart, using whitespace as a delimeter.
            }
            foreach (string[] entry in splitByWord)
            {
                Node temp = new Node(entry[0].Substring(0, 1)); //We create a new node for each line, naming it the first entry of each line.
            }
            foreach (string[] entry in splitByWord)
            {
                Node curr = Node.getNodeByName(entry[0].Substring(0, 1)); //Next, we create the necessary edges
                if(entry.Length == 1)
                {
                    continue;
                }
                for (int i = 1; i < entry.Length - 1; i = i + 2) //This calculation determines how many edges per node
                {
                    curr.addEdge(Node.getNodeByName(entry[i]), Convert.ToInt32(entry[i + 1])); //We create new edges.
                }
            }
            foreach(Edge entry in Edge.edgeList)
            {
                Console.WriteLine(entry.WeightedToString());
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
