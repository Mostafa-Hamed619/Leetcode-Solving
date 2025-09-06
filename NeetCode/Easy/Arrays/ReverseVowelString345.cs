namespace NeetCode.Easy.Arrays
{
    public class ReverseVowelString345
    {
        char[] Vowels = ['A', 'a', 'E', 'e', 'O', 'o', 'I', 'i', 'U', 'u'];

        public string ReverseVowels(string s)
        {
            int i = 0;
            int j = s.Length - 1;

            char[] arr = s.ToCharArray();
            while (i < j)
            {
                bool IsLeftVowel = (Vowels.Contains(arr[i]));
                bool IsRightVowel = (Vowels.Contains(arr[j]));

                if (!IsRightVowel)
                {
                    j--;
                }
                else if (!IsLeftVowel)
                {
                    i++;
                }
                else
                {
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            return new string(arr);
        }
    }
}
