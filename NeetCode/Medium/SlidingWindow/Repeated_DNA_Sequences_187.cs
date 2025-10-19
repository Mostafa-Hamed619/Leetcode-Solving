namespace NeetCode.Medium.SlidingWindow
{
    public class Repeated_DNA_Sequences_187
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            HashSet<string> seen = new();
            HashSet<string> duplicate = new();

            for (int i = 0; i <= s.Length - 10; i++)
            {
                string subText = s.Substring(i, 10);
                if (!seen.Add(subText))
                {
                    duplicate.Add(subText);
                }
            }
            return duplicate.ToList();
        }
    }
}
