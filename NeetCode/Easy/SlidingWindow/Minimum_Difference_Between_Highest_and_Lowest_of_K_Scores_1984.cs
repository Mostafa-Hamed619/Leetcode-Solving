namespace NeetCode.Easy.SlidingWindow
{
    public class Minimum_Difference_Between_Highest_and_Lowest_of_K_Scores_1984
    {
        public int MinimumDifference(int[] nums, int k)
        {
            int MinDiff = int.MaxValue;
            int WindowDiff = 0;

            Array.Sort(nums);
            if (nums.Length == 1)
            {
                return 0;
            }

            for (int left = 0; left <= nums.Length - k; left++)
            {
                WindowDiff = nums[left + k - 1] - nums[left];

                MinDiff = Math.Min(WindowDiff, MinDiff);
            }
            return MinDiff;
        }
    }
}
