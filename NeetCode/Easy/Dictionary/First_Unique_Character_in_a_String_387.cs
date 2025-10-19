namespace NeetCode.Easy.Dictionary
{
    public class First_Unique_Character_in_a_String_387
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> Map = new();

            foreach (var i in s)
            {
                if (Map.ContainsKey(i))
                    Map[i]++;
                else
                {
                    Map[i] = 0;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (Map[s[i]] != 0)
                    continue;
                return i;
            }
            return -1;
        }
    }
}
