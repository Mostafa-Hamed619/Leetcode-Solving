using System.Text;

namespace NeetCode.Easy.Arrays
{
    public class LargestNumberSOl
    {
        public string LargestNumber(int[] nums)
        {
            StringBuilder Result = new StringBuilder();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Result.Append(nums[i]);
            }

            return Result.ToString();
        }

    }
}
