namespace NeetCode.Medium.Dictionary
{
    public class Top_K_Frequent_Words_692
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, int> Map = new();

            foreach (var i in words)
            {
                if (Map.ContainsKey(i))
                    Map[i]++;
                else
                    Map[i] = 1;
            }

            return Map.OrderByDescending(m => m.Value).ThenBy(m => m.Key).Take(k).Select(m => m.Key).ToList();
        }
    }
}
