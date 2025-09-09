namespace NeetCode.Medium.SlidingWindow
{
    public class Longest_Subarray_of_1_s_After_Deleting_One_Element_1493
    {
        public int LongestSubarray(int[] nums)
        {
            int Number_Zeros = 1;
            int Start = 0;
            int Max_Sequence = 0;
            for (int End = 0; End < nums.Length; End++)
            {
                if (nums[End] == 0)
                {
                    Number_Zeros--;
                }

                while (Number_Zeros < 0)
                {
                    if (nums[Start] == 0)
                    {
                        Number_Zeros++;
                    }
                    Start++;
                }
                Max_Sequence = Math.Max(Max_Sequence, (End - Start));
            }
            return Max_Sequence;
        }
    }
}
