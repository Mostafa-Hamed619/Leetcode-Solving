namespace NeetCode.Medium.Stack
{
    public class Remove_Stars_From_A_String_2390
    {
        public string RemoveStars(string s)
        {
            Stack<char> stack = new();
            int star_number = 0;

            foreach (var i in s.Reverse())
            {
                if (i == '*')
                {
                    star_number++;
                    continue;
                }
                else
                {
                    if (star_number > 0)
                    {
                        star_number--;
                        continue;
                    }
                    else
                    {
                        stack.Push(i);
                    }
                }
            }

            return new string(stack.ToArray());
        }
    }
}
