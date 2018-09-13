using System;

namespace LeetCode.Intro.ArrayAndString
{
    public class TwoPointerTechnique
    {
        //https://leetcode.com/problems/reverse-string/description/
        public string ReverseString(string s)
        {

            var arr = new char[s.Length];
            var i = 0;
            var j = s.Length - 1;
            while (i <= j)
            {
                arr[i] = s[j];
                arr[j] = s[i];
                i++;
                j--;
            }
            return new string(arr);
        }

        //https://leetcode.com/problems/array-partition-i/description/
        public int ArrayPairSum(int[] nums)
        {
            int sum = 0;

            Array.Sort(nums);

            for (var i = 0; i < nums.Length; i += 2)
                sum += nums[i];

            return sum;


        }

        //https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/
        public int[] TwoSum(int[] numbers, int target)
        {

            var i = 0;
            var j = numbers.Length - 1;
            while (i < j)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return new int[] { i + 1, j + 1 };
                }
                else if (numbers[i] + numbers[j] < target)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }


            return new int[0];
        }

        //https://leetcode.com/problems/remove-element/description/
        public int RemoveElement(int[] nums, int val)
        {

            var insertPos = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[insertPos++] = nums[i];
                }
            }
            return insertPos;

        }

        //https://leetcode.com/problems/max-consecutive-ones/description/
        public int FindMaxConsecutiveOnes(int[] nums)
        {

            var max = 0;
            var curr = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    curr = 0;
                }
                else
                {
                    curr++;
                    if (max < curr) max = curr;
                }
            }

            return max;


        }


        //https://leetcode.com/problems/minimum-size-subarray-sum/description/
        public int MinSubArrayLen(int s, int[] nums)
        {

            var minLen = int.MaxValue;
            var curTotal = 0;
            var start = 0;
            for (int end = 0; end < nums.Length; end++)
            {
                curTotal += nums[end];

                while (curTotal >= s && start <= end)
                {

                    if (minLen > end - start + 1)
                        minLen = end - start + 1;

                    curTotal -= nums[start++];
                }
            }

            return minLen == int.MaxValue ? 0 : minLen;


        }


    }
}