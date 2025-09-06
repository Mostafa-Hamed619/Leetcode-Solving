namespace NeetCode.Easy.Dictionary
{
    public class LongestHarmoniousSubsequence594
    {
        public int FindLHS(int[] nums)
        {
            Dictionary<int, int> Hash = new();
            int maxCount = 0;

            int HashCount = 0;
            foreach (var i in nums)
            {
                if (Hash.ContainsKey(i))
                {
                    Hash[i]++;
                }
                else
                {
                    Hash[i] = 1;
                }
            }

            foreach (var i in nums)
            {
                if (Hash.ContainsKey(i + 1))
                {
                    HashCount = Hash[i] + Hash[i + 1];
                }
                maxCount = Math.Max(maxCount, HashCount);
            }
            return maxCount;
        }
    }
}
