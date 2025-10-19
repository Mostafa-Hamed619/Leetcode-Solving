namespace NeetCode.Medium.SlidingWindow
{
    public class Maximum_NumberofsubstringVowel
    {
        public int MaxVowels(string s, int k)
        {
            HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };
            int vowelCount = 0;
            int MaxCount = 0;

            for (int i = 0; i < k; i++)
            {
                if (vowels.Contains(s[i]))
                    vowelCount++;
            }
            MaxCount = vowelCount;
            for (int i = k; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                    vowelCount++;
                if (vowels.Contains(s[i - k]))
                    vowelCount--;

                MaxCount = Math.Max(vowelCount, MaxCount);
            }
            return MaxCount;
        }
    }
}
