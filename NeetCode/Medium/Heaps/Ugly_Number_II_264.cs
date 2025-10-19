namespace NeetCode.Medium.Heaps
{
    public class Ugly_Number_II_264
    {
        public int NthUglyNumber(int n)
        {
            PriorityQueue<int, int> Heap = new();
            HashSet<int> Visited = new();
            int Priority = 1;
            int[] Prime_Factors = { 2, 3, 5 };

            Heap.Enqueue(1, Priority);
            Visited.Add(1);
            for (int i = 0; i < n; i++)
            {
                int Current = Heap.Dequeue();

                if (i == n - 1)
                    return Current;

                foreach (var prime in Prime_Factors)
                {
                    long Multiply = (long)Current * prime;
                    if (Multiply <= int.MaxValue && Visited.Add((int)Multiply))
                    {
                        Heap.Enqueue((int)Multiply, (int)Multiply);
                    }
                }
            }
            return 1;

            #region most optimal
            //int[] ugly = new int[n];
            //ugly[0] = 1;

            //int i2 = 0, i3 = 0, i5 = 0;
            //int next2 = 2, next3 = 3, next5 = 5;

            //for (int i = 1; i < n; i++)
            //{
            //    int nextUgly = Math.Min(next2, Math.Min(next3, next5));
            //    ugly[i] = nextUgly;

            //    if (nextUgly == next2) next2 = 2 * ugly[++i2];
            //    if (nextUgly == next3) next3 = 3 * ugly[++i3];
            //    if (nextUgly == next5) next5 = 5 * ugly[++i5];
            //}

            //return ugly[n - 1];

            #endregion
        }
    }
}
