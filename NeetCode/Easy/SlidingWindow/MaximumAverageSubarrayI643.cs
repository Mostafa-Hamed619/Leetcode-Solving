namespace NeetCode.Easy.SlidingWindow
{
    public class MaximumAverageSubarrayI643
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double MaxSum = 0;
            for (int i = 0; i < k; i++)
            {
                MaxSum += nums[i];
            }
            double MaxAverage = MaxSum / k;

            double WindowmSum = MaxSum;
            for (int i = k; i < nums.Length; i++)
            {
                WindowmSum += nums[i] - nums[i - k];

                double WindowAverage = WindowmSum / k;

                MaxAverage = Math.Max(MaxAverage, WindowAverage);
            }
            return MaxAverage;
        }
    }
}
