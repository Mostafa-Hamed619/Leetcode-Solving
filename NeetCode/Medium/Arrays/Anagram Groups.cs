using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Medium.Arrays
{
    public class Anagram_Groups
    {
        public static List<List<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 0)
            {
                return new List<List<string>>();
            }

            Dictionary<string, List<string>> Anagrams = new Dictionary<string, List<string>>();

            foreach (string word in strs)
            {
                int[] Count = new int[26];

                foreach (char c in word)
                {
                    Count[c - 'a']++;
                }

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < Count.Length; i++)
                {
                    sb.Append("#");
                    sb.Append(Count[i]);
                }

                string key = sb.ToString();
                if (!Anagrams.ContainsKey(key))
                {
                    Anagrams[key] = new List<string>();
                }

                Anagrams[key].Add(word);

            }

            return new List<List<string>>(Anagrams.Values);
        }
    }
}
