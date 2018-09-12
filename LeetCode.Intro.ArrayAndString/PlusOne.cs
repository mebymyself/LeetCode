﻿namespace LeetCode.Intro.ArrayAndString
{
    /*
     Given a non-empty array of digits representing a non-negative integer, plus one to the integer.
       
       The digits are stored such that the most significant digit is at the head of the list, and each element in the array contain a single digit.
       
       You may assume the integer does not contain any leading zero, except the number 0 itself.
       
       Example 1:
       
       Input: [1,2,3]
       Output: [1,2,4]
       Explanation: The array represents the integer 123.
       Example 2:
       
       Input: [4,3,2,1]
       Output: [4,3,2,2]
       Explanation: The array represents the integer 4321.
       */

    public class PlusOne1148
    {
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