namespace SortFindMedian
{
    public class Program
    {
        static void Main(string[] args)
        {
            
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

        public static int GetIndexSmallestElement(int[] array, int arrayIndex)
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
        public static void SortArray(int[] array)
        {
            int length = array.Length;
            for(int i = 0; i<length; i++)
            {
                int indexCurrentSmallestElement = GetIndexSmallestElement(array, i);
                int temporal = array[indexCurrentSmallestElement];
                array[indexCurrentSmallestElement] = array[i];
                array[i] = temporal;
            }
        }

    }
}