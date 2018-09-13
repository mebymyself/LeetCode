using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Xunit;

namespace LeetCode.Intro.ArrayAndString.Tests
{
    public class IntroTo2DArrayTests
    {
        private IntroTo2DArray sut;
        public IntroTo2DArrayTests()
        {
            sut = new IntroTo2DArray();
        }

        public class FindDiagonalOrder : IntroTo2DArrayTests
        {
            [Fact]
            public void FindDiagonalOrder_Example1()
            {
                var input = new int[,]
                {
                    {1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}
                };

                var expected = new[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 };

                var result = sut.FindDiagonalOrder(input);

                Assert.Equal(expected, result);
            }
        }

        public class SpiralOrder : IntroTo2DArrayTests
        {
            [Fact]
            public void SpiralOrder_Example1()
            {
                var input = new int[,]
                {
                    {1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}
                };

                var expected = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

                var result = sut.SpiralOrder(input);

                Assert.Equal(expected, result);
            }
        }

        public class GeneratePascalsTriangle : IntroTo2DArrayTests
        {
            [Fact]
            public void GeneratePascalsTriangle_Example1()
            {
                var input = 5;

                IList<IList<int>> expected = new[]
                {
                    new []{ 1 },
                    new []{ 1,1 },
                    new []{ 1,2,1 },
                    new []{ 1,3,3,1 },
                    new []{ 1,4,6,4,1 }

                };

                var result = sut.GeneratePascalsTriangle(input);

                Assert.Equal(expected, result);
            }
        }

    }
}