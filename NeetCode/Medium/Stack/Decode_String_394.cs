namespace NeetCode.Medium.Stack
{
    public class Decode_String_394
    {
        public string DecodeString(string s)
        {
            Stack<char> stack = new();

            foreach (var i in s)
            {
                if (i != ']')
                    stack.Push(i);
                else
                {
                    string sp = "";
                    while (stack.Peek() != '[')
                    {
                        sp = stack.Pop() + sp;
                    }
                    stack.Pop();

                    string number = "";
                    while (stack.Count > 0 && char.IsDigit(stack.Peek()))
                    {
                        number = stack.Pop() + number;
                    }
                    int repeat = int.Parse(number);

                    for (int k = 0; k < repeat; k++)
                    {
                        foreach (char c in sp)
                        {
                            stack.Push(c);
                        }
                    }
                }
            }
            return new string(stack.Reverse().ToArray());
        }
    }
}