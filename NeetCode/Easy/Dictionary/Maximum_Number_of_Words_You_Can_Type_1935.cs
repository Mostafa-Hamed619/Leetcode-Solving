namespace NeetCode.Easy.Dictionary
{
    public class Maximum_Number_of_Words_You_Can_Type_1935
    {
        public int CanBeTypedWords(string text, string brokenLetters)
        {
            bool[] Map = new bool[26];
            char[] charText = text.ToCharArray();

            foreach (var ch in brokenLetters)
            {
                Map[ch - 'a'] = true;
            }

            bool canType = true;
            int count = 0;
            foreach (var i in charText)
            {
                if (i == ' ')
                {
                    if (canType == true)
                        count++;
                    canType = true;
                }
                else
                {
                    if (Map[i - 'a'])
                        canType = false;
                }
            }

            if (canType) // for the last character
            {
                count++;
            }
            return count;
        }
    }
}
