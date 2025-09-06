public class DefuseTheBomb
{
    public int[] Decrypt(int[] code, int k)
    {
        int n = code.Length;
        int sum = 0;
        int[] result = new int[n];

        int left = 1; int right = k;
        if (k < 0)
        {
            left = n - Math.Abs(k);
            right = n - 1;
        }
        for (int i = left; i <= right; i++)
        {
            sum += code[i];
        }

        for (int i = 0; i < n; i++)
        {
            result[i] = sum;

            sum -= code[left % n];
            sum += code[(right + 1) % n];
            left++;
            right++;
        }
        return result;
    }
}