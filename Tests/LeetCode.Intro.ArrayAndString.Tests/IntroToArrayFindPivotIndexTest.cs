using System;
using Xunit;

namespace LeetCode.Intro.ArrayAndString.Tests
{
    public class IntroToArrayFindPivotIndexTest
    {
        private IntroToArrayFindPivotIndex sut;

        public IntroToArrayFindPivotIndexTest()
        {
            sut = new IntroToArrayFindPivotIndex();
        }

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
            var nums = new[] { 1, 2,3 };
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
}
