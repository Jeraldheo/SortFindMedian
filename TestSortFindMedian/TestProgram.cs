

using SortFindMedian;

namespace TestSortFindMedian
{
    public class TestProgram
    {
        public static IEnumerable<object[]> TestDataTwoDemensionToOneDimension
            => new[]
            {
                new object[]{new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0},
                            new int[,]{ {0, 0, 0 },{0, 0, 0 },{0, 0, 0 } } },

                new object[]{new int[]{17, 9, 36, 8, 7, 3, 15, 28, 57},
                            new int[,]{ {17, 9, 36 },{8, 7, 3 },{15, 28, 57 } } },

                new object[]{new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9},
                            new int[,]{ { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } } }

            };

        [Theory]
        [MemberData(nameof(TestDataTwoDemensionToOneDimension))]
        public static void Test_TwoDemensionToOneDimension(int[] expectedArray, int[,] matrix)
        {
            int[] array = Program.TwoDimensionToOneDimension(matrix);
            Assert.Equal(expectedArray, array);
        }

        public static IEnumerable<object[]> TestDataGetIndexSmallestElement
            => new[]
            {
                new object[]{5, new int[] { 17, 9, 36, 8, 7, 3, 15, 28, 57 }, 0},
                new object[]{0, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0},
                new object[]{8, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 0},
                new object[]{4, new int[] { 1, 2, 3, 4, 0, 6, 7, 8, 9 }, 0},
                new object[]{3, new int[] { 2, 9, 4, 0, 7, 25, 3, 1, 19 }, 0},
                new object[]{7, new int[] { 2, 9, 4, 0, 7, 25, 3, 1, 19 }, 4}

            };

        [Theory]
        [MemberData(nameof(TestDataGetIndexSmallestElement))]
        public static void Test_GetIndexSmallestElement(int expectedIndex, int[] array, int arrayIndex)
        {
            int index = Program.GetIndexSmallestElement(array, arrayIndex);
            Assert.Equal(expectedIndex, index);
        }


        public static IEnumerable<object[]> TestDataSortArray
            => new[]
            {
                new object[]{ new int[] { 3, 7, 8, 9, 15, 17, 28, 36, 57 }, new int[] { 17, 9, 36, 8, 7, 3, 15, 28, 57 }},
                new object[]{ new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }},
                new object[]{ new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }},
                new object[]{ new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }},
                new object[]{ new int[] { 1, 1, 1, 1, 1, 2, 2, 2, 2 }, new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1 }},
                new object[]{ new int[] {1}, new int[] {1} }

            };
        [Theory]
        [MemberData(nameof(TestDataSortArray))]
        public static void Test_SortArray(int[] expectedSortedArray, int[] array)
        {
            Program.SortArray(array);
            Assert.Equal(expectedSortedArray, array);
        }
    }
}