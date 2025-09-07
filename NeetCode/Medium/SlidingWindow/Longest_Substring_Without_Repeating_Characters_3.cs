namespace NeetCode.Medium.SlidingWindow
{
    public class Longest_Substring_Without_Repeating_Characters_3
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> Map = new();
            int MaxCount = 0;
            int Start = 0;
            for (int End = 0; End < s.Length; End++)
            {
                while (Map.Contains(s[End]))
                {
                    Map.Remove(s[Start]);
                    Start++;
                }
                Map.Add(s[End]);
                MaxCount = Math.Max(Map.Count(), MaxCount);
            }
            return MaxCount;
        }
    }
}
