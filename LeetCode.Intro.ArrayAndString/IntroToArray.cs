using System.Linq;

namespace LeetCode.Intro.ArrayAndString
{

    public class IntroToArray
    {
        //https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1144/
        public int PivotIndex(int[] nums)
        {
            if (nums == null || nums.Length == 0) return -1;

            var total = nums.Sum();
            var left = 0;
            var right = total;
            for (var i = 0; i < nums.Length; i++)
            {
                if (i > 0)
                {
                    left += nums[i - 1];
                }
                right -= nums[i];
                if (left == right) return i;
            }
            return -1;

        }

        //https://leetcode.com/explore/learn/card/array-and-string/201/introduction-to-array/1147/
        public int DominantIndex(int[] nums)
        {

            var largest = 0;
            var largestIndex = -1;

            var second = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (largest < nums[i])
                {
                    largest = nums[i];
                    largestIndex = i;
                }
            }
            for (var i = 0; i < nums.Length; i++)
            {
                if (second < nums[i] && nums[i] < largest)
                {
                    second = nums[i];
                }
            }


            if (second * 2 <= largest) return largestIndex;

            return -1;


        }

        //https://leetcode.com/problems/plus-one/description/
        public int[] PlusOne(int[] digits)
        {
            var overflow = true;
            var i = digits.Length - 1;
            while (i >= 0 && overflow)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] += 1;
                    overflow = false;
                }
                i--;
            }
            if (overflow)
            {
                var arr = new int[digits.Length + 1];
                arr[0] = 1;
                for (var j = 1; j < arr.Length; j++)
                {
                    arr[j] = digits[j - 1];
                }
                return arr;
            }

            return digits;

        }
    }
}
