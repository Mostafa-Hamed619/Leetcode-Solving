namespace NeetCode.Easy.Arrays
{
    public class FindIndexOfTheFirstOccurence
    {
        public int StrStr(string haystack, string needle)
        {

            if (string.IsNullOrEmpty(needle)) return 0;
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if ((haystack.Substring(i, needle.Length)) == needle)
                {
                    return i;
                }
            }
            return -1;

        }
    }
}
