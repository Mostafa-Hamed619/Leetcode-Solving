namespace NeetCode.Easy.Prefix_Sum
{
    public class Find_The_Highest_Gain_1732
    {
        public int LargestAltitude(int[] gain)
        {
            int[] Report = new int[gain.Length + 1];
            int gain_value = 0;
            int Max_gain = 0;
            Report[0] = gain_value;
            for (int i = 0; i < gain.Length; i++)
            {
                gain_value = gain[i] + Report[i];
                Report[i + 1] = gain_value;

                Max_gain = Math.Max(Max_gain, gain_value);
            }

            if (Max_gain < 0)
            {
                Max_gain = 0;
            }
            return Max_gain;

        }
    }
}
