namespace NeetCode.Easy.Arrays
{
    public class Determine_if_Two_Strings_Are_Close_1657
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;

            int[] Array1 = new int[26];
            int[] Array2 = new int[26];

            for (int i = 0; i < word1.Length; i++)
            {
                Array1[word1[i] - 'a']++;
            }

            for (int i = 0; i < word1.Length; i++)
            {
                Array2[word2[i] - 'a']++;
            }

            for (int i = 0; i < 26; i++)
            {
                if ((Array1[i] == 0) != (Array2[i] == 0))
                {
                    return false;
                }
            }

            Array.Sort(Array1);
            Array.Sort(Array2);

            for (int i = 0; i < Array1.Length; i++)
            {
                if (Array1[i] != Array2[i])
                    return false;
            }

            return true;
        }
    }
}
