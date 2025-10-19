namespace NeetCode.Medium.MathProb
{
    public class Pow
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;
            if (n < 0)
                return 1 / MyPow(x, -n);
            return x * MyPow(x, n - 1);
        }
    }
}