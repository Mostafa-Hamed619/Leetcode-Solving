namespace NeetCode.Medium.Heaps
{
    public class Kth_Largest_Element_in_an_Array
    {
        public int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int, int> queue = new();
            int result = 0;

            #region 
            Array.Sort(nums);
            int priority = 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                queue.Enqueue(nums[i], priority++);
            }

            for (int i = k; i > 0; i--)
            {
                result = queue.Dequeue();
            }
            #endregion


            #region Optimized Code
            foreach (var i in nums)
            {
                queue.Enqueue(i, -i);
            }

            for (int i = 0; i < k; i++)
            {
                result = queue.Dequeue();
            }
            #endregion
            return result;

        }
    }
}
