namespace NeetCode.Easy.Arrays
{
    public class Largest_Perimeter_Triangle_976
    {
        public int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);

            for (int i = nums.Count() - 1; i >= 2; i--)
            {
                if (nums[i] < nums[i - 1] + nums[i - 2])
                {
                    return nums[i] + nums[i - 1] + nums[i - 2];
                }
            }
            return 0;
        }
    }
}
