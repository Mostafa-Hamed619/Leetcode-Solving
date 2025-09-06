namespace NeetCode.Easy.Arrays
{
    public class Can_Place_Flowers
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (n == 0)
                return true;
            for (int i = 0; i < flowerbed.Length && n > 0; i++)
            {
                if (flowerbed[i] == 0)
                {
                    var isLeftEmpty = (i == 0) || (flowerbed[i - 1] == 0);
                    var isRightEmpty = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

                    if (isLeftEmpty && isRightEmpty)
                    {
                        flowerbed[i] = 1;
                        n--;
                    }

                    if (n == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
