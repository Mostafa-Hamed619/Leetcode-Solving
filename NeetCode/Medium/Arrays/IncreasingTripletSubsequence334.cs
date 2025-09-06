namespace NeetCode.Medium.Arrays
{
    public class IncreasingTripletSubsequence334
    {
        public bool IncreasingTriplet(int[] nums)
        {
            int Min = int.MaxValue;
            int Max = int.MaxValue;


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= Min)
                    Min = nums[i];
                else if (nums[i] <= Max)
                    Max = nums[i];
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
