namespace NeetCode.Easy.Dictionary
{
    public class Find_Resultant_Array_After_Removing_Anagrams_2273
    {
        public IList<string> RemoveAnagrams(string[] words)
        {
            List<string> result = new();

            result.Add(words[0]);

            for (int i = 1; i < words.Length; i++)
            {
                if (IsNotAnagram(word2: words[i], word1: words[i - 1]))
                    result.Add(words[i]);
            }
            return result;
        }

        private static bool IsNotAnagram(string word2, string word1)
        {
            if (word1.Length != word2.Length)
                return true;

            int[] CharactersArraya = new int[26];

            for (int i = 0; i < word1.Length; i++)
            {
                CharactersArraya[word1[i] - 'a']++;
            }

            for (int i = 0; i < word2.Length; i++)
            {
                if (--CharactersArraya[word2[i] - 'a'] < 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
