namespace NeetCode.Easy.Dictionary
{
    class Find_Most_Frequent_Vowel_and_Consonant_3541
    {
        public int MaxFreqSum(string s)
        {
            char[] vowels = { 'a', 'o', 'u', 'e', 'i' };
            Dictionary<char, int> Map = new();
            int max_vowel = 0;
            int max_const = 0;

            foreach (var i in s)
            {
                if (Map.ContainsKey(i))
                    Map[i]++;
                else
                    Map[i] = 1;
            }

            foreach (var i in Map)
            {
                if (vowels.Contains(i.Key))
                {
                    if (i.Value > max_vowel)
                    {
                        max_vowel = i.Value;
                    }
                }
                else
                {
                    if (i.Value > max_const)
                    {
                        max_const = i.Value;
                    }
                }
            }

            return max_const + max_vowel;
        }
    }
}
