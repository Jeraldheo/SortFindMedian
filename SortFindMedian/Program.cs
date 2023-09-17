using System.Text;

namespace SortFindMedian
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[,] { { 17, 9, 36 }, { 8, 7, 3 }, { 15, 28, 57 } };
            double[] array = TwoDimensionToOneDimension(matrix);
            //Array.Sort(array); Time complexity O(nlogn) from standard library.
            SortArray(array);
            Console.WriteLine($"Elementos ordenados: {ArrayToString(array)}");
            Console.WriteLine($"Mediana: {ComputeMedian(array)}");
        }

        public static double[] TwoDimensionToOneDimension(double[,] matrix)
        {
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1); 
            double[] array = new double[numRows*numCols];
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

        public static int GetIndexSmallestElement(double[] array, int arrayIndex)
        {
            int indexSmallestElement = arrayIndex;
            int length = array.Length;
            for(int i = indexSmallestElement + 1; i<length; i++)
            {
                if (array[i] < array[indexSmallestElement])
                {
                    indexSmallestElement = i;
                }
            }
            return indexSmallestElement;
        }

        //Time complexity O(n^2)
        public static void SortArray(double[] array)
        {
            int length = array.Length;
            for(int i = 0; i<length; i++)
            {
                int indexCurrentSmallestElement = GetIndexSmallestElement(array, i);
                double temporal = array[indexCurrentSmallestElement];
                array[indexCurrentSmallestElement] = array[i];
                array[i] = temporal;
            }
        }

        public static double ComputeMedian(double[] sortedArray)
        {
            int numElements = sortedArray.Length;
            double median = 0;
            if(numElements%2==0)
            {
                int indexRightElement = numElements / 2;
                int indexLeftElement = indexRightElement-1;
                median = (sortedArray[indexLeftElement] + sortedArray[indexRightElement])/2;
            }
            else
            {
                int medianIndex  = numElements/2;
                median = sortedArray[medianIndex];
            }
            return median;
        }

        private static string ArrayToString(double[] array)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int size = array.Length;

            for (int i = 0; i < size - 1; i++)
            {
                stringBuilder.Append(array[i] + ", ");
            }

            stringBuilder.Append(array[size - 1]);
            return stringBuilder.ToString();
        }

    }
}