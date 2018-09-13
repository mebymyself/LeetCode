namespace LeetCode.Intro.ArrayAndString
{
    public class MaxConsecutiveOnes1301
    {
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
    }
}