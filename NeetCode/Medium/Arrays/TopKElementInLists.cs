using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode.Medium.Arrays
{
    public static class TopKElementInLists
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> Count = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (Count.ContainsKey(num)) Count[num]++;
                else Count[num] = 1;
            }

            List<int[]> arr = Count.Select(count => new int[] { count.Value, count.Key }).ToList();

            arr.Sort((a, b) => b[0].CompareTo(a[0]));

            int[] result = new int[k];
            for (int i = 0; i < k; i++)
            {
                result[i] = arr[i][1];
            }

            return result;
        }
    }
}
