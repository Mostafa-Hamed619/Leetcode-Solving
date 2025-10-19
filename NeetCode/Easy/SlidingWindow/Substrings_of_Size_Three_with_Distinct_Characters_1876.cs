namespace NeetCode.Easy.SlidingWindow
{
    public class Substrings_of_Size_Three_with_Distinct_Characters_1876
    {
        public int CountGoodSubstrings(string s)
        {
            if (s.Length < 3)
                return 0;

            HashSet<char> Window = new();
            int count = 0;
            int left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (Window.Contains(s[right]))
                {
                    Window.Remove(s[left]);
                    left++;
                }
                Window.Add(s[right]);

                if (right - left + 1 > 3)
                {
                    Window.Remove(s[left]);
                    left++;
                }

                if (right - left + 1 == 3 && Window.Count == 3)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
