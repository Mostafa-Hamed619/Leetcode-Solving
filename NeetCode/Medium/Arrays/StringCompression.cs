namespace NeetCode.Medium.Arrays
{
    public class StringCompression
    {
        int count = 1;
        int writes = 0;
        public int Compress(char[] chars)
        {
            for (int i = 1; i <= chars.Length; i++)
            {
                if (i == chars.Length || chars[i] != chars[i - 1])
                {
                    chars[writes++] = chars[i - 1];

                    if (count > 1)
                    {
                        foreach (char c in count.ToString())
                        {
                            chars[writes++] = c;
                        }
                    }
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            return writes;
        }
    }
}
