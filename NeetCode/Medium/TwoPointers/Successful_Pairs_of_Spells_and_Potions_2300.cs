namespace NeetCode.Medium.TwoPointers
{
    public class Successful_Pairs_of_Spells_and_Potions_2300
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            int[] results = new int[spells.Length];
            Array.Sort(potions);
            for (int i = 0; i < spells.Length; i++)
            {
                int left = 0; int right = potions.Length - 1;
                int ValidSuccess = potions.Length;

                while (left <= right)
                {
                    int Mid = left + (right - left) / 2;
                    long Multiply = (long)spells[i] * potions[Mid];
                    if (Multiply >= success)
                    {
                        ValidSuccess = Mid;
                        right = Mid - 1;
                    }
                    else
                    {
                        left = Mid + 1;
                    }
                    Console.WriteLine(Multiply);
                }

                results[i] = potions.Length - ValidSuccess;
            }
            return results;
        }
    }
}
