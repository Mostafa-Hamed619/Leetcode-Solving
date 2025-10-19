namespace NeetCode.Medium.Arrays
{
    internal class LongestConsequetiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {

            int result = 0;
            HashSet<int> HashNum = new HashSet<int>(nums);
            foreach (var num in nums)
            {
                int Count = 0;
                int Current = num;
                while (HashNum.Contains(Current))
                {
                    Count++;
                    Current++;
                }

                result = Math.Max(result, Count);
            }

            return result;
        }
    }
}
