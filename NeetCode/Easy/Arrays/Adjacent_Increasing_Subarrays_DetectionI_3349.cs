namespace NeetCode.Easy.Arrays
{
    public class Adjacent_Increasing_Subarrays_DetectionI_3349
    {
        public bool HasIncreasingSubarrays(IList<int> nums, int k)
        {
            int n = nums.Count;
            int index = 0;
            int current = 1;

            for (int i = 1; i < n; i++)
            {
                if (nums[i] > nums[i - 1])
                    current++;
                else
                {
                    if (current / 2 >= k || Math.Min(index, current) >= k)
                        return true;
                    index = current;
                    current = 1;
                }
            }

            if (current / 2 >= k || Math.Min(index, current) >= k)
                return true;
            return false;
        }
    }
}
