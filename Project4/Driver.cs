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
