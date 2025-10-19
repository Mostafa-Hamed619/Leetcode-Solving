namespace NeetCode.Medium.Arrays
{
    public class Smallest_Missing_Nonnegative_Integer_After_Operations_2598
    {
        public int FindSmallestInteger(int[] nums, int value)
        {
            HashSet<int> Reminder = new();
            int Current = 0;
            int Smallest = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                num = ((num % value) + value) % value;

                if (!Reminder.Contains(num))
                {
                    Reminder.Add(num);
                    Current++;
                }
            }

            while (true)
            {
                int rem = ((Smallest % value) + value) % value;

                if (!Reminder.Contains(rem))
                    return Smallest;
                Smallest++;
            }

        }
    }
}
