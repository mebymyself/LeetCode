using Xunit;

namespace LeetCode.Intro.ArrayAndString.Tests
{
    public class MaxConsecutiveOnes1301Tests
    {
        private MaxConsecutiveOnes1301 sut;
        public MaxConsecutiveOnes1301Tests()
        {
            sut = new MaxConsecutiveOnes1301();
        }

        [Fact]
        public void MaxConsecutiveOnes_Example1()
        {
            var input = new[] {1, 1, 0, 1, 1, 1};
            var expected = 3;

            var result = sut.FindMaxConsecutiveOnes(input);

            Assert.Equal(expected, result);
        }

    }
}