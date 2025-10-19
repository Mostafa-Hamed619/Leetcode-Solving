namespace NeetCode.Easy.Arrays
{
    public class Water_Bottles_1518
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            if (numBottles < numExchange)
                return numBottles;

            int reminder = 0;
            int total = numBottles;

            while (numBottles >= numExchange)
            {
                reminder = numBottles % numExchange;
                numBottles = numBottles / numExchange;
                total += numBottles;
                numBottles += reminder;
            }

            return total;
        }
    }
}
