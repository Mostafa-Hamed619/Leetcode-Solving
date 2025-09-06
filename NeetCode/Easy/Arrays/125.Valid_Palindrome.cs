using System.Text;

namespace NeetCode.Easy.Arrays
{
    public class Valid_Palindrome
    {
        public bool IsPalindrome(string s)
        {
            StringBuilder sb = new StringBuilder();

            bool result = true;
            foreach (var i in s)
            {
                if (char.IsLetterOrDigit(i))
                {
                    sb.Append(char.ToLower(i));
                }
            }

            if (sb.Length == 0)
            {
                return result;
            }


            for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
            {
                if (sb[i] == sb[j])
                {
                    continue;
                }
                else
                {
                    return result = false;
                }
            }
            return result;
        }
    }
}
