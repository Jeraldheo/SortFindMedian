

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


    }
}