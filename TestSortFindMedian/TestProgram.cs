

using SortFindMedian;

namespace TestSortFindMedian
{
    public class TestProgram
    {
        public static IEnumerable<object[]> TestDataTwoDemensionToOneDimension
            => new[]
            {
                new object[]{new double[]{0, 0, 0, 0, 0, 0, 0, 0, 0},
                            new double[,]{ {0, 0, 0 },{0, 0, 0 },{0, 0, 0 } } },

                new object[]{new double[]{17, 9, 36, 8, 7, 3, 15, 28, 57},
                            new double[,]{ {17, 9, 36 },{8, 7, 3 },{15, 28, 57 } } },

                new object[]{new double[]{1, 2, 3, 4, 5, 6, 7, 8, 9},
                            new double[,]{ { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } } }

            };

        [Theory]
        [MemberData(nameof(TestDataTwoDemensionToOneDimension))]
        public static void Test_TwoDemensionToOneDimension(double[] expectedArray, double[,] matrix)
        {
            double[] array = Program.TwoDimensionToOneDimension(matrix);
            Assert.Equal(expectedArray, array);
        }

        public static IEnumerable<object[]> TestDataGetIndexSmallestElement
            => new[]
            {
                new object[]{5, new double[] { 17, 9, 36, 8, 7, 3, 15, 28, 57 }, 0},
                new object[]{0, new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0},
                new object[]{8, new double[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, 0},
                new object[]{4, new double[] { 1, 2, 3, 4, 0, 6, 7, 8, 9 }, 0},
                new object[]{3, new double[] { 2, 9, 4, 0, 7, 25, 3, 1, 19 }, 0},
                new object[]{7, new double[] { 2, 9, 4, 0, 7, 25, 3, 1, 19 }, 4}

            };

        [Theory]
        [MemberData(nameof(TestDataGetIndexSmallestElement))]
        public static void Test_GetIndexSmallestElement(int expectedIndex, double[] array, int arrayIndex)
        {
            int index = Program.GetIndexSmallestElement(array, arrayIndex);
            Assert.Equal(expectedIndex, index);
        }


        public static IEnumerable<object[]> TestDataSortArray
            => new[]
            {
                new object[]{ new double[] { 3, 7, 8, 9, 15, 17, 28, 36, 57 }, new double[] { 17, 9, 36, 8, 7, 3, 15, 28, 57 }},
                new object[]{ new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }},
                new object[]{ new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new double[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }},
                new object[]{ new double[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }, new double[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }},
                new object[]{ new double[] { 1, 1, 1, 1, 1, 2, 2, 2, 2 }, new double[] { 1, 2, 1, 2, 1, 2, 1, 2, 1 }},
                new object[]{ new double[] {1}, new double[] {1} }

            };
        [Theory]
        [MemberData(nameof(TestDataSortArray))]
        public static void Test_SortArray(double[] expectedSortedArray, double[] array)
        {
            Program.SortArray(array);
            Assert.Equal(expectedSortedArray, array);
        }

        public static IEnumerable<object[]> TestDataComputeMedian
            => new[]
            {
                new object[]{15, new double[] { 3, 7, 8, 9, 15, 17, 28, 36, 57 }},
                new object[]{3, new double[] { 1, 2, 3, 4, 5 }},
                new object[]{5, new double[] { 2, 3, 4, 6, 7, 8 }},
                new object[]{2, new double[] { 2 }},
                new object[]{2.5, new double[] { 2, 3 }},


            };
        [Theory]
        [MemberData(nameof(TestDataComputeMedian))]
        public static void Test_ComputeMedian(double expectedMedian, double[] sortedArray)
        {
            double median = Program.ComputeMedian(sortedArray);
            Assert.Equal(expectedMedian, median);

        }
    }
}