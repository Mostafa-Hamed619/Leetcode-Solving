namespace NeetCode.Medium.Dictionary
{
    public class Equal_Row_Equal_Column
    {
        public int EqualPairs(int[][] grid)
        {
            int N = grid.Length;
            Dictionary<string, int> TextMap = new();


            // for inserting the rows.
            for (int r = 0; r < N; r++)
            {
                string Row = string.Join(",", grid[r]);
                if (TextMap.ContainsKey(Row))
                    TextMap[Row]++;
                else
                    TextMap[Row] = 1;
            }

            int Count = 0;
            // for reversing the column with row to compare if any one is same to other.
            for (int column = 0; column < N; column++)
            {
                int[] col = new int[N];

                for (int row = 0; row < N; row++)
                {
                    col[row] = grid[row][column];
                }
                string Key = string.Join(",", col);

                if (TextMap.ContainsKey(Key))
                    Count += TextMap[Key];
            }

            return Count;
        }
    }
}
