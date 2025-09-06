namespace NeetCode.Medium.Arrays
{
    class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int j = 0;
            int[] nums2 = new int[nums.Length];
            k = k % nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + k >= nums.Length)
                {
                    j = (i + k) - nums.Length;
                    nums2[j] = nums[i];
                }
                else
                {
                    nums2[i + k] = nums[i];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums2[i];
            }

        }
    }
}
