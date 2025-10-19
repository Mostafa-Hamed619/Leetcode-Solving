namespace NeetCode.Easy.Dictionary
{
    public class Word_Pattern_290
    {
        public bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> patternMap = new();
            string[] sArr = s.Split(" ");

            if (pattern.Length != sArr.Length)
                return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                char p = pattern[i];
                if (!patternMap.ContainsKey(pattern[i]))
                {
                    if (patternMap.ContainsValue(sArr[i]))
                    {
                        return false;
                    }
                    patternMap.Add(p, sArr[i]);
                }
            }

            int j = 0;
            int index = 0;
            while (index < sArr.Length && j < pattern.Length)
            {
                char p = pattern[j];

                if (patternMap[p] != sArr[index])
                {
                    return false;
                }
                index++;
                j++;
            }
            return true;
        }
    }
}
