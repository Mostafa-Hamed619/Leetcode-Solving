namespace NeetCode.Medium.Greedy
{
    public class Maximum_Number_Distinct_Elements_After_Operations_3397
    {
        public int MaxDistinctElements(int[] nums, int k)
        {
            Array.Sort(nums);

            int n = nums.Length;
            int distinctCount = 0;
            int previousValue = int.MinValue;

            foreach (var current in nums)
            {
                int optimalValue = Math.Min(current + k, Math.Max(current - k, previousValue + 1));

                if (optimalValue > previousValue)
                {
                    distinctCount++;
                    previousValue = optimalValue;
                }
            }

            return distinctCount;
        }
    }
}
