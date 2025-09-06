namespace NeetCode.Medium.Arrays
{
    public class ReverseWordsinString151
    {
        public string ReverseWords(string s)
        {
            string[] arr = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            int j = arr.Length - 1;

            while (i < j)
            {
                Swap(ref arr[i], ref arr[j]);
                i++;
                j--;
            }
            return string.Join(" ", arr);
        }

        public void Swap(ref string A, ref string B)
        {
            string Temp = string.Empty;
            Temp = A;
            A = B;
            B = Temp;
        }
    }
}
