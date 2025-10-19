namespace NeetCode.Medium.Dictionary
{
    public class Maximum_Total_Damage_With_Spell_Casting_3186
    {
        public long MaximumTotalDamage(int[] power)
        {
            Dictionary<int, long> Frequency = new();
            foreach (var p in power)
            {
                if (Frequency.ContainsKey(p))
                    Frequency[p]++;
                else
                    Frequency[p] = 1;
            }

            int[] uniquePowers = Frequency.Keys.OrderBy(x => x).ToArray();
            int n = uniquePowers.Length;

            if (n == 0)
                return 0;

            long[] dp = new long[n];
            dp[0] = uniquePowers[0] * Frequency[uniquePowers[0]];

            for (int i = 1; i < n; i++)
            {
                long currentValue = uniquePowers[i] * Frequency[uniquePowers[i]];

                int j = i - 1;
                while (j >= 0 && Math.Abs(uniquePowers[i] - uniquePowers[j]) <= 2)
                    j--;

                long include = currentValue + (j >= 0 ? dp[j] : 0);
                long exclude = dp[i - 1];
                dp[i] = Math.Max(include, exclude);
            }

            return dp[n - 1];
        }

        private static int[] FindValidCases(Dictionary<int, long> Frequency, int power)
        {
            // Step 1: Define invalid cases (within ±2)
            int[] InvalidCases = { power - 2, power - 1, power + 1, power + 2 };
            List<int> results = new();

            // Step 2: Add only valid powers
            foreach (var kvp in Frequency)
            {
                if (!InvalidCases.Contains(kvp.Key))
                    results.Add(kvp.Key);
            }

            return results.ToArray();
        }


    }
}
