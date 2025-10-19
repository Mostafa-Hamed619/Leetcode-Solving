namespace NeetCode.Easy.TwoPointers
{
    public class Palidrome_Number_9
    {
        public bool IsPalindrome(int x)
        {
            string Text = x.ToString();
            bool Result = false;


            int j = Text.Length - 1;
            for (int i = 0; i <= j; i++, j--)
            {
                if (Text[i] == Text[j])
                    Result = true;
                else
                {
                    return false;
                }
            }
            return Result;
        }
    }
}
