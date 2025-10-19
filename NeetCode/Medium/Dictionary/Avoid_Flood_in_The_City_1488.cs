namespace NeetCode.Medium.Dictionary
{
    public class Avoid_Flood_in_The_City_1488
    {
        public int[] AvoidFlood(int[] rains)
        {
            int n = rains.Length;
            int[] result = new int[n];

            // Map to track last day each lake got rain
            Dictionary<int, int> full = new();

            // SortedSet to keep indices of dry days (0 days)
            SortedSet<int> dryDays = new();

            for (int i = 0; i < n; i++)
            {
                int lake = rains[i];

                if (lake == 0)
                {
                    dryDays.Add(i);
                    result[i] = 1;
                }
                else
                {
                    if (full.ContainsKey(lake))
                    {
                        int lastRainDay = full[lake];

                        int? dryDay = null;
                        foreach (int day in dryDays)
                        {
                            if (day > lastRainDay)
                            {
                                dryDay = day;
                                break;
                            }
                        }

                        if (dryDay == null)
                            return Array.Empty<int>();

                        result[dryDay.Value] = lake;
                        dryDays.Remove(dryDay.Value);
                    }

                    full[lake] = i;

                    result[i] = -1;
                }
            }

            return result;
        }
    }
}