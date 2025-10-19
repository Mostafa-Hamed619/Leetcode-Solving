namespace NeetCode.Medium
{
    public class Taking_Maximum_Energy_From_the_Mystic_Dungeon_3147
    {

        #region Time Limit Exceeded
        //public int MaximumEnergy(int[] energy, int k)
        //{
        //    int Sum = 0;
        //    int MaxSum = int.MinValue;
        //    for (int i = 0; i < energy.Length; i++)
        //    {
        //        Sum = canJump(energy, i, k);
        //        MaxSum = Math.Max(MaxSum, Sum);
        //    }
        //    return MaxSum;
        //}

        //private static int canJump(int[] energy, int Index, int k)
        //{
        //    int n = energy.Length;

        //    if (Index >= n)
        //        return 0;

        //    int Prefix = energy[Index];

        //    if (Index + k >= n)
        //        return Prefix;

        //    return Prefix + canJump(energy, Index + k, k);
        //}
        #endregion

        public int MaximumEnergy(int[] energy, int k)
        {
            int n = energy.Length;
            int[] dp = new int[n];
            int MaxSum = int.MinValue;

            for (int i = n - 1; i >= 0; i--)
            {
                if (i + k < n)
                    dp[i] = energy[i] + dp[i + k];
                else
                    dp[i] = energy[i];

                MaxSum = Math.Max(MaxSum, dp[i]);
            }

            return MaxSum;
        }
    }
}
