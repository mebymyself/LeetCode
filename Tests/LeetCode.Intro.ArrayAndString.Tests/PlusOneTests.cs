using Xunit;

namespace LeetCode.Intro.ArrayAndString.Tests
{
    public class PlusOneTests
    {
        private PlusOne1148 sut;

        public PlusOneTests()
        {
            sut = new PlusOne1148();
        }

        [Fact]
        public void DominantIndex_Example1()
        {
            var input = new int[] {1,2,3 };
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
            var expected = new int[] { 1,0 };

            var result = sut.PlusOne(input);

            Assert.Equal(expected, result);
        }
    }
}