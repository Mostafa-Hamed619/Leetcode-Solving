namespace NeetCode.Easy.Dictionary
{
    class Unique_Number_of_Occurrences_1207
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> Map = new();
            foreach (var num in arr)
            {
                if (Map.ContainsKey(num))
                {
                    Map[num]++;
                }
                else
                {
                    Map[num] = 1;
                }
            }

            HashSet<int> Set = new();

            foreach (var i in Map.Values)
            {
                if (Set.Contains(i))
                    return false;
                Set.Add(i);
            }
            return true;
        }
    }
}
