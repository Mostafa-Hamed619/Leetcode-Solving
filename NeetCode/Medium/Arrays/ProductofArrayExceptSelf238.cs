namespace NeetCode.Medium.Arrays
{
    public class ProductofArrayExceptSelf238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] Rarr = new int[nums.Length];
            int[] Larr = new int[nums.Length];

            int[] Output = new int[nums.Length];
            int i = 0, j = nums.Length - 1;

            Larr[i] = 1; Rarr[j] = 1;

            while (i < Larr.Length - 1 && j >= 0)
            {
                Larr[i + 1] = nums[i] * Larr[i];
                Rarr[j - 1] = nums[j] * Rarr[j];
                i++;
                j--;
            }
            i = 0;
            j = nums.Length - 1;

            for (; i < Output.Length; i++)
            {
                Output[i] = Larr[i] * Rarr[i];
            }

            return Output;
        }
    }
}
