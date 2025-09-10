namespace NeetCode.Easy.TwoPointers
{
    public class MoveZeros
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 1)
                Console.WriteLine(nums[0]);
            int i = 0;
            int j = i + 1;

            while (j < nums.Length)
            {
                bool SwapCondition = (nums[i] == 0 && nums[j] != 0);
                bool SkipCondition = (nums[i] == 0 && nums[j] == 0);
                if (SwapCondition)
                {
                    Swap(ref nums[i], ref nums[j]);
                    i++;
                    j++;
                }
                else if (SkipCondition)
                {
                    j++;
                }
            }
        }

        private void Swap(ref int a, ref int b)
        {
            int Temp = a;
            a = b;
            b = Temp;
        }
    }
}
