namespace NeetCode.Medium.Heaps
{
    public class Top_K_Frequent_Elements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> Map = new();

            int[] result = new int[k];
            foreach (var i in nums)
            {
                if (Map.ContainsKey(i))
                    Map[i]++;
                else
                    Map[i] = 1;
            }

            PriorityQueue<int, int> queue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            foreach (var i in Map)
            {
                queue.Enqueue(i.Key, i.Value);
            }

            for (int i = 0; i < k; i++)
            {
                result[i] = queue.Dequeue();
            }
            return result;
        }
    }
}
