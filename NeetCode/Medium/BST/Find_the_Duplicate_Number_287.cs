namespace NeetCode.Medium.BST
{
    public class Find_the_Duplicate_Number_287
    {
        public int FindDuplicate(int[] nums)
        {
            int left = 1; int right = nums.Length - 1;

            while (left < right)
            {
                int Count = 0;
                int Mid = (left + right) / 2;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] <= Mid)
                    {
                        Count++;
                    }
                }
                if (Count > Mid)
                    right = Mid;
                else
                    left = Mid + 1;
            }
            return left;
        }
    }
}
