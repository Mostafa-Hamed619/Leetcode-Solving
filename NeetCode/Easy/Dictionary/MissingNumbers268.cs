namespace NeetCode.Easy.Dictionary
{
    public class MissingNumbers268
    {
        public int MissingNumber(int[] nums)
        {
            int N = nums.Length;
            int MissedNumber = 0;
            HashSet<int> Map = new();


            for (int i = 0; i < nums.Length; i++)
            {
                Map.Add(nums[i]);
            }

            for (int i = 0; i <= N; i++)
            {
                if (!Map.Contains(i))
                {
                    return MissedNumber = i;
                }
            }
            return MissedNumber;
        }
    }
}
