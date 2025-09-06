namespace NeetCode.Medium.Arrays
{
    class RemoveDuplicatesFromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2)
                return nums.Length;

            int totalOfAppearence = 1;
            int totalOfCheck = 1;
            int currentValue = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == currentValue)
                {
                    if (totalOfCheck < 2)
                    {
                        nums[totalOfAppearence] = nums[i];
                        totalOfAppearence++;
                        totalOfCheck++;
                    }
                }
                else
                {
                    currentValue = nums[i];
                    totalOfCheck = 1;
                    nums[totalOfAppearence] = nums[i];
                    totalOfAppearence++;
                }
            }

            return totalOfAppearence;
        }
    }
}
