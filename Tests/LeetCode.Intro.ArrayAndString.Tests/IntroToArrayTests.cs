using Xunit;

namespace LeetCode.Intro.ArrayAndString.Tests
{
    public class IntroToArrayTests
    {
        private IntroToArray sut;
        public IntroToArrayTests()
        {
            sut = new IntroToArray();
        }


        public class PivotIndex : IntroToArrayTests
        {
            [Fact]
            public void PivotIndex_Example_1()
            {

                var nums = new[] { 1, 7, 3, 6, 5, 6 };
                var expected = 3;

                var result = sut.PivotIndex(nums);

                Assert.Equal(expected, result);

            }

            [Fact]
            public void PivotIndex_Example_2()
            {
                var nums = new[] { 1, 2, 3 };
                var expected = -1;

                var result = sut.PivotIndex(nums);

                Assert.Equal(expected, result);

            }

            [Fact]
            public void PivotIndex_Example_null()
            {

                var expected = -1;

                var result = sut.PivotIndex(null);

                Assert.Equal(expected, result);

            }

            [Fact]
            public void PivotIndex_Example_Empty()
            {
                var nums = new int[0];
                var expected = -1;

                var result = sut.PivotIndex(null);

                Assert.Equal(expected, result);

            }
        }

        public class DominantIndex: IntroToArrayTests
        {
            [Fact]
            public void DominantIndex_Example1()
            {
                var input = new int[] { 3, 6, 1, 0 };
                var expected = 1;

                var result = sut.DominantIndex(input);

                Assert.Equal(expected, result);
            }
            [Fact]
            public void DominantIndex_Example2()
            {
                var input = new int[] { 1, 2, 3, 4 };
                var expected = -1;

                var result = sut.DominantIndex(input);

                Assert.Equal(expected, result);
            }
        }

        public class PlusOneTests : IntroToArrayTests
        {
            [Fact]
            public void DominantIndex_Example1()
            {
                var input = new int[] { 1, 2, 3 };
                var expected = new int[] { 1, 2, 4 };

                var result = sut.PlusOne(input);

                Assert.Equal(expected, result);
            }

            [Fact]
            public void DominantIndex_Example2()
            {
                var input = new int[] { 4, 3, 2, 1 };
                var expected = new int[] { 4, 3, 2, 2 };

                var result = sut.PlusOne(input);

                Assert.Equal(expected, result);
            }

            [Fact]
            public void DominantIndex_Example3()
            {
                var input = new int[] { 9 };
                var expected = new int[] { 1, 0 };

                var result = sut.PlusOne(input);

                Assert.Equal(expected, result);
            }
        }

    } 
}