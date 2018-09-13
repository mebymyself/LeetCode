using Xunit;

namespace LeetCode.Intro.ArrayAndString.Tests
{
    public class TwoPointerTechniqueTests
    {
        private TwoPointerTechnique sut;
        public TwoPointerTechniqueTests()
        {
            sut = new TwoPointerTechnique();
        }

        public class ReverseString : TwoPointerTechniqueTests
        {
            [Fact]
            public void ReverseString_Example1()
            {
                var input = "hello";
                var expected = "olleh";

                var result = sut.ReverseString(input);

                Assert.Equal(expected, result);
            }
            [Fact]
            public void ReverseString_Example2()
            {
                var input = "A man, a plan, a canal: Panama";
                var expected = "amanaP :lanac a ,nalp a ,nam A";

                var result = sut.ReverseString(input);

                Assert.Equal(expected, result);
            }

        }

        public class ArrayPairSum : TwoPointerTechniqueTests
        {
            [Fact]
            public void ArrayPairSum_Example1()
            {
                var input = new[] { 1, 4, 3, 2 };
                var expected = 4;

                var result = sut.ArrayPairSum(input);

                Assert.Equal(expected, result);
            }

        }

        public class TwoSum : TwoPointerTechniqueTests
        {
            [Fact]
            public void TwoSum_Example1()
            {
                var numbers = new[] { 2, 7, 11, 15 };
                var target = 9;

                var expected = new[] { 1,2 };

                var result = sut.TwoSum(numbers, target);

                Assert.Equal(expected, result);
            }

        }

        public class RemoveElement : TwoPointerTechniqueTests
        {
            [Fact]
            public void RemoveElement_Example1()
            {
                var numbers = new[] { 3, 2, 2, 3 };
                var val = 3;

                var expected = 2;

                var result = sut.RemoveElement(numbers, val);

                Assert.Equal(expected, result);
            }
            [Fact]
            public void RemoveElement_Example2()
            {
                var numbers = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
                var val = 2;

                var expected = 5;

                var result = sut.RemoveElement(numbers, val);

                Assert.Equal(expected, result);
            }
        }

        public class FindMaxConsecutiveOnes : TwoPointerTechniqueTests
        {
            [Fact]
            public void FindMaxConsecutiveOnes_Example1()
            {
                var input = new[] { 1, 1, 0, 1, 1, 1 };
                var expected = 3;

                var result = sut.FindMaxConsecutiveOnes(input);

                Assert.Equal(expected, result);
            }

        }
        public class MinSubArrayLen : TwoPointerTechniqueTests
        {
            [Fact]
            public void MinSubArrayLen_Example1()
            {
                var input = new[] { 2, 3, 1, 2, 4, 3 };
                var s = 7;
                var expected = 2;

                var result = sut.MinSubArrayLen(s, input);

                Assert.Equal(expected, result);
            }

        }
    }
}