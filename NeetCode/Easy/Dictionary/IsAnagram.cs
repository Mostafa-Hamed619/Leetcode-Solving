namespace NeetCode.Easy.Dictionary
{
    public class Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<int, int> Map = new();
            bool Result = true;
            foreach (var i in s)
            {
                if (Map.ContainsKey(i))
                {
                    Map[i]++;
                }
                else
                {
                    Map[i] = 1;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (Map.ContainsKey(t[i]))
                {
                    Map[t[i]]--;
                    if (Map[t[i]] < 0)
                    {
                        Result = false;
                        break;
                    }
                }
                else
                {
                    Result = false;
                    break;
                }
            }

            if (Result && Map.Values.Any(v => v != 0))
            {
                Result = false;
            }
            return Result;
        }
    }
}
