namespace NeetCode.Easy.SlidingWindow
{
    public class Longest_Nice_Substring_1763
    {
        public string LongestNiceSubstring(string s)
        {
            if (s.Length < 2)
                return "";

            HashSet<char> set = new();

            foreach (var c in s)
                set.Add(c);

            for (int i = 0; i < s.Length; i++)
            {
                if (set.Contains(char.ToUpper(s[i])) && set.Contains(char.ToLower(s[i])))
                    continue;

                string subs1 = LongestNiceSubstring(s.Substring(0, i));
                string subs2 = LongestNiceSubstring(s.Substring(i + 1, s.Length - i - 1));

                return subs1.Length >= subs2.Length ? subs1 : subs2;
            }

            return s;
        }

    }
}
