namespace NeetCode.Easy.Prefix_Sum
{
    public class Find_Pivot_Index_724
    {
        public int PivotIndex(int[] nums)
        {
            int Left = 0;
            int Right = nums.Length - 1;
            int[] Larr = new int[nums.Length]; Larr[Left] = 0;
            int[] Rarr = new int[nums.Length]; Rarr[Right] = 0;
            Left++; Right--;
            for (; Left < nums.Length; Left++, Right--)
            {
                Larr[Left] = nums[Left - 1] + Larr[Left - 1];
                Rarr[Right] = nums[Right + 1] + Rarr[Right + 1];
            }
            Left = 0; Right = nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (Larr[i] == Rarr[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
