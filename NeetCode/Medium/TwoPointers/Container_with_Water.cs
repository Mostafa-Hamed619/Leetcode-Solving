namespace NeetCode.Medium.TwoPointers
{
    public class Container_with_Water
    {
        int MinLength(int Left, int Right)
        {
            return Left < Right ? Left : Right;
        }

        public int MaxArea(int[] height)
        {
            int MaxArea = 0;
            int Area = 0;
            int Length, Width = 0;
            int Left = 0;
            int Right = height.Length - 1;


            while (Left < Right)
            {
                Length = MinLength(height[Left], height[Right]);
                Width = Right - Left;

                Area = Length * Width;
                if (MaxArea < Area)
                {
                    MaxArea = Area;
                }
                if (height[Left] < height[Right])
                {
                    Left++;
                }
                else
                {
                    Right--;
                }
            }

            return MaxArea;
        }
    }
}
