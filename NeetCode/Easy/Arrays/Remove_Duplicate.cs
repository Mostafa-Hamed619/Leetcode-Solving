namespace NeetCode.Easy.Arrays
{
    public class Remove_Duplicate
    {
        public int RemoveDuplicates(int[] nums)
        {
            int total = 0;
            int currentValue = int.MinValue;

            foreach (var x in nums)
            {
                if (currentValue != x)
                {
                    total++;
                    nums[total - 1] = x;
                }

                currentValue = x;
            }
            return total;
        }
    }
}
