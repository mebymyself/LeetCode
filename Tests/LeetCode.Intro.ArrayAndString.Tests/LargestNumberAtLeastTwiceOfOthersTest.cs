using Xunit;

namespace LeetCode.Intro.ArrayAndString.Tests
{
    public class LargestNumberAtLeastTwiceOfOthersTest
    {
        private LargestNumberAtLeastTwiceOfOthers sut;

        public LargestNumberAtLeastTwiceOfOthersTest()
        {
            sut = new LargestNumberAtLeastTwiceOfOthers();
        }

        [Fact]
        public void DominantIndex_Example1()
        {
            var input = new int[] {3, 6, 1, 0};
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
}