namespace NeetCode.Hard
{
    public class Finding_Missing_Positive_Number_41
    {
        public int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            // Step 1: Replace negatives and zeros with 0
            for (int i = 0; i < n; i++)
            {
                if (nums[i] < 0)
                    nums[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                int value = Math.Abs(nums[i]);
                if (value >= 1 && value <= n)
                {
                    if (nums[value - 1] > 0)
                    {
                        nums[value - 1] *= -1;
                    }
                    else if (nums[value - 1] == 0)
                    {
                        nums[value - 1] = -1 * (n + 1);
                    }
                }
            }

            // Step 3: Find first missing positive
            for (int i = 0; i < n; i++)
            {
                if (nums[i] >= 0)
                {
                    return i + 1; // because index 0 represents number 1
                }
            }

            return n + 1;
        }
    }
}
