namespace NeetCode.Medium.SlidingWindow
{
    public class MaximumNumberofVowelsaSubstringofGivenLength1456
    {
        public int MaxVowels(string s, int k)
        {
            int currentVowels = 0;
            string test = String.Empty;

            test = s.Substring(0, k);

            foreach (var t in test.ToLower())
            {
                if (IsVowel(t))
                    currentVowels++;
            }
            int MaxVowel = currentVowels;

            for (int i = k; i < s.Length; i++)
            {
                if (IsVowel(s[i]))
                    currentVowels++;
                if (IsVowel(s[i - k]))
                    currentVowels--;

                MaxVowel = Math.Max(MaxVowel, currentVowels);

                if (MaxVowel == k)
                {
                    return k;
                }
            }
            return MaxVowel;
        }

        private bool IsVowel(char character)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            return vowels.Contains(character);
        }
    }
}
