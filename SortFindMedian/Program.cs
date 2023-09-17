﻿namespace SortFindMedian
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int[] TwoDimensionToOneDimension(int[,] matrix)
        {
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1); 
            int[] array = new int[numRows*numCols];
            for(int i = 0; i<numRows; i++)
            {
                for(int j = 0; j<numCols; j++)
                {
                    int oneDimensionalIndex = numRows*i + j;
                    array[oneDimensionalIndex] = matrix[i, j];
                }
            }
            return array;
        }
    }
}