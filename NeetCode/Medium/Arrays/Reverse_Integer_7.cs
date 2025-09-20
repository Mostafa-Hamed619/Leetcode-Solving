namespace NeetCode.Medium.Arrays
{
    public class Reverse_Integer_7
    {
        public int Reverse(int x)
        {
            int Min = (int)Math.Pow(-2, 31);
            int Max = (int)(Math.Pow(2, 31) - 1);

            int result = 0;

            while (x != 0)
            {
                int digit = x % 10;
                x = x / 10;

                if (result > Max / 10 || (result == Max / 10 && digit > 7))
                    return 0;
                if (result < Min / 10 || (result == Min / 10 && digit < -8))
                    return 0;

                result = (result * 10) + digit;

            }

            return result;
        }
    }
}
