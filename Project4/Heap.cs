using System;
using System.Collections.Generic;
using System.Text;

namespace Project4
{
    static class Heap
    {

        public static void sort(List<Edge> input) //Here is our entry point into the program, the only public accessible function.
        {
            buildHeap(input);
            heapSort(input);
        }
        private static void buildHeap(List<Edge> input)
        {
            for (int i = parent(input.Count - 1); i > -1; i--)
            {
                heapify(input, i, input.Count);
            }
        }
        private static void heapify(List<Edge> input, int index, int heapLength)
        {
            int leftIndex = left(index);
            int rightIndex = right(index);
            int largerIndex = index;
            if ((leftIndex < heapLength) && (input[largerIndex] < input[leftIndex]))
            {
                largerIndex = leftIndex;
            }
            if ((rightIndex < heapLength) && (input[largerIndex] < input[rightIndex]))
            {
                largerIndex = rightIndex;
            }
            if (largerIndex != index)
            {
                swap(input, largerIndex, index);
                heapify(input, largerIndex, heapLength);
            }
        }
        private static void heapSort(List<Edge> input)
        {
            for (int i = input.Count - 1; i > 0; i--)
            {
                swap(input, 0, i);
                heapify(input, 0, i);
            }
        }
        private static int left(int index)
        {
            return (2 * index + 1);
        }
        private static int right(int index)
        {
            return (2 * index + 2);
        }
        private static int parent(int index)
        {
            return (index - 1) / 2;
        }
        private static void swap(List<Edge> input, int index1, int index2)
        {
            Edge temp = input[index1];
            input[index1] = input[index2];
            input[index2] = temp;
        }
    }
}
