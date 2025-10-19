namespace Easy.SlidingWindow
{
    public class ContainsDuplicateII219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            HashSet<int> Hash = new();
            int counter = 0;
            int N = nums.Length;
            for (int i = 0; i < N; i++)
            {
                if (Hash.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    Hash.Add(nums[i]);
                    counter++;
                }
                if (counter > k)
                {
                    Hash.Remove(nums[i - k]);
                    counter--;
                }
            }
            return false;
        }
    }
}
