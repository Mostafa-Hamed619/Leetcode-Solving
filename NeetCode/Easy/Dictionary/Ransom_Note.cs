namespace NeetCode.Easy.Dictionary
{
    public class Ransom_Note
    {
        static Dictionary<char, int> MakeCountMap(string magazine)
        {
            Dictionary<char, int> Map = new();
            foreach (var c in magazine)
            {
                if (Map.ContainsKey(c))
                {
                    Map[c]++;
                }
                else
                {
                    Map[c] = 1;
                }
            }
            return Map;
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
                return false;
            Dictionary<char, int> MagazineMap = MakeCountMap(magazine);

            foreach (var c in ransomNote)
            {
                if (!MagazineMap.ContainsKey(c) || MagazineMap[c] == 0)
                {
                    return false;
                }
                else
                {
                    MagazineMap[c]--;
                }
            }
            return true;
        }
    }
}
