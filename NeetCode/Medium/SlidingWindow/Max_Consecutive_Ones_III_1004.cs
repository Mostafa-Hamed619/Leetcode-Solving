namespace NeetCode.Medium.SlidingWindow
{
    public class Max_Consecutive_Ones_III_1004
    {
        public int LongestOnes(int[] nums, int k)
        {
            int Max_Window = 0;
            int Num_Zeros = 0;
            int Left = 0;

            for (int Right = 0; Right < nums.Length; Right++)
            {
                if (nums[Right] == 0)
                {
                    Num_Zeros++;
                }

                while (Num_Zeros > k)
                {
                    if (nums[Left] == 0)
                        Num_Zeros--;

                    Left++;
                }
                Max_Window = Math.Max(Max_Window, Right - Left + 1);
            }
            return Max_Window;
        }
    }
}
