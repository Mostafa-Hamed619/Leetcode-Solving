namespace NeetCode.Medium.SlidingWindow
{
    // 2,3,1,2,4,3      Target = 7
    public class Minimum_Size_Subarray_Sum_209
    {

        public int MinSubArrayLen(int target, int[] nums)
        {
            int MinLength = int.MaxValue;
            int left = 0;
            int sum = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                while (sum >= target)
                {
                    MinLength = Math.Min(MinLength, right - left + 1);
                    sum -= nums[left];
                    left++;
                }
            }
            if (MinLength == int.MaxValue) return 0;
            else return MinLength;
        }
    }
}
